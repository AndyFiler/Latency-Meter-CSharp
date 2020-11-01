using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.IO.Ports;

//Just wanned to say, fuck commenting code!

namespace GameIntegratedLatencyMeter
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);
        public Form1()
        {
            InitializeComponent();
        }

        public class MouseOperations
        {
            [Flags]
            public enum MouseEventFlags
            {
                LeftDown = 0x00000002,
                LeftUp = 0x00000004,
                MiddleDown = 0x00000020,
                MiddleUp = 0x00000040,
                Move = 0x00000001,
                Absolute = 0x00008000,
                RightDown = 0x00000008,
                RightUp = 0x00000010
            }

            [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool SetCursorPos(int x, int y);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool GetCursorPos(out MousePoint lpMousePoint);

            [DllImport("user32.dll")]
            private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

            public static void SetCursorPosition(int x, int y)
            {
                SetCursorPos(x, y);
            }

            public static void SetCursorPosition(MousePoint point)
            {
                SetCursorPos(point.X, point.Y);
            }

            public static MousePoint GetCursorPosition()
            {
                MousePoint currentMousePoint;
                var gotPoint = GetCursorPos(out currentMousePoint);
                if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
                return currentMousePoint;
            }

            public static void MouseEvent(MouseEventFlags value)
            {
                MousePoint position = GetCursorPosition();

                mouse_event
                    ((int)value,
                     position.X,
                     position.Y,
                     0,
                     0)
                    ;
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct MousePoint
            {
                public int X;
                public int Y;

                public MousePoint(int x, int y)
                {
                    X = x;
                    Y = y;
                }
            }

            public static void MouseClick()
            {
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                //Thread.Sleep(delay);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
            }

        }

        public void CheckMouseLat()
        {
            serialPort1.WriteLine("a");
            Pingsw = new Stopwatch();
            Pingsw.Start();
        }

        public void addMs(Label label)
        {
            label.Text = label.Text + "ms";
        }

        public int GetLastMouse()
        {
            if (MouseLatData.Count <= 0)
                return 0;
            else
                return MouseLatData.Last();
        }

        Stopwatch Pingsw;
        List<int> SysLatData = new List<int>();
        List<int> MouseLatData = new List<int>();
        List<int> PCLatData = new List<int>();

        private void RunService(object sender, EventArgs e)
        {
            string PortName;
            if (!serialPort1.IsOpen)
            {
                if (PortCB.SelectedIndex <= -1)
                    PortName = serialPort1.PortName;
                else
                    PortName = PortCB.Text;
                serialPort1.PortName = PortName;
            }
            if (serialPort1.IsOpen)
			{
				serialPort1.Close();
				try
				{
					serialPort1.Open();
                }
				catch (Exception)
				{
					MessageBox.Show("Port not accessible", "Warning");
				}
			}
			else
		    	try
		    	{
				serialPort1.Open();
		    	}
		    	catch (Exception)
		    	{
			    MessageBox.Show("Port not accessible", "Warning");
			    }
            Thread.Sleep(200);
            if (serialPort1.IsOpen)
            {
                CheckMouseLat();
            }
		}

        private void Received(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
			string IncData = serialPort1.ReadLine();

			if (IncData.Contains("b")) {
                if(IntegratedCheck.Checked)
                MouseOperations.MouseClick();
                else
                {
                    DetectionZone.BackColor = Color.White;
                }
            }
            else if (IncData.Contains("z")) {
                Pingsw.Stop();
                TimeSpan ts = Pingsw.Elapsed;
                MouseLatData.Add(ts.Milliseconds);
                MouseLat.Text = ts.Milliseconds.ToString() + "ms";
                MinMouseLat.Text = MouseLatData.Min().ToString() + "ms";
                AvgMouseLat.Text = ((float)MouseLatData.Sum() / (float)MouseLatData.Count()).ToString("F") + "ms";
            }
            else
            {
                int intData = Int32.Parse(IncData) - GetLastMouse();
                int SysintData = Int32.Parse(IncData);
                if (SysintData > 10 && SysintData < 300)
                {
                    PCLatData.Add(intData);
                    SysLatData.Add(SysintData);
                    SysLat.Text = SysintData.ToString() + "ms";
                    MinSysLat.Text = SysLatData.Min().ToString() + "ms";
                    AvgSysLat.Text = ((float)SysLatData.Sum() / (float)SysLatData.Count()).ToString("F") + "ms";
                    PCLat.Text = intData.ToString() + "ms";
                    MinPCLat.Text = PCLatData.Min().ToString() + "ms";
                    AvgPCLat.Text = ((float)PCLatData.Sum() / (float)PCLatData.Count()).ToString("F") + "ms";
                    if (!IntegratedCheck.Checked)
                        DetectionZone.BackColor = Color.Black;
                    CheckMouseLat();
                }
            }
        }

        private void ResetData(object sender, EventArgs e)
        {
            SysLatData.Clear();
            MouseLatData.Clear();
            PCLatData.Clear();
            MouseLat.Text = "0ms";
            MinMouseLat.Text = "0ms";
            AvgMouseLat.Text = "0ms";
            SysLat.Text = "0ms";
            MinSysLat.Text = "0ms";
            AvgSysLat.Text = "0ms";
            PCLat.Text = "0ms";
            MinPCLat.Text = "0ms";
            AvgPCLat.Text = "0ms";
        }

        private void StopService(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void SaveCurrent(object sender, EventArgs e)
        {
            SavesPanel.RowCount++;
            Label NameLab = new Label();
            NameLab.Text = SaveNameBox.Text;
            //NameLab.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
            Label SysAvgLab = new Label();
            SysAvgLab.Text = AvgSysLat.Text;
            Label MouseAvgLab = new Label();
            MouseAvgLab.Text = AvgMouseLat.Text;
            Label SysMinLab = new Label();
            SysMinLab.Text = MinSysLat.Text;

            SavesPanel.Controls.Add(NameLab);
            SavesPanel.Controls.Add(SysAvgLab);
            SavesPanel.Controls.Add(MouseAvgLab);
            SavesPanel.Controls.Add(SysMinLab);
        }

        private void ExportData(object sender, EventArgs e)
        {
            if (ExportName.TextLength > 0)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SystemLatencyMeter");
                var FilePath = Path.Combine(path, (ExportName.Text + ".SLM"));
                var Files = File.Create(FilePath);
                using (var fs = new StreamWriter(Files))
                {
                    int row = 1;
                    int col = 0;
                    for (row = 1; row <= SavesPanel.RowCount - 1; row++)
                    {
                        for (col = 0; col <= SavesPanel.ColumnCount - 1; col++)
                        {
                            fs.WriteLine(SavesPanel.GetControlFromPosition(col, row).Text);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Please, name your file first", "Warning");
        }

        private void ImportData(object sender, EventArgs e)
        {
            if (FileCB.Text.Length > 0)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SystemLatencyMeter");
                var fileName = path + "/" + FileCB.Text + ".SLM";
                var lines = File.ReadLines(fileName);
                int lineNum = 0;
                foreach (var line in lines)
                {
                    lineNum++;
                    if (lineNum % 4 == 0)
                    {
                        SavesPanel.RowCount++;
                    }
                    Label NewLineLabel = new Label();
                    NewLineLabel.Text = line;
                    SavesPanel.Controls.Add(NewLineLabel);
                }
            }
            else
                MessageBox.Show("Please, select a file to import", "Warning");
        }

        private void RemoveData(object sender, EventArgs e)
        {
            if (FileCB.Text.Length > 0)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SystemLatencyMeter");
                var fileName = path + "/" + FileCB.Text + ".SLM";
                File.Delete(fileName);
                FileCB.Text = "";
            }
            else
                MessageBox.Show("Please, select a file to remove", "Warning");
        }

            private void UpdateFiles(object sender, EventArgs e)
        {
            FileCB.Items.Clear();
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SystemLatencyMeter");
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SystemLatencyMeter");
            DirectoryInfo d = new DirectoryInfo(filepath);
            foreach (var file in d.GetFiles("*.SLM"))
            {
                FileCB.Items.Add((file.Name).Remove(file.Name.Length - 4));
            }
        }

        private void UpdatePorts(object sender, EventArgs e)
        {
            PortCB.Items.Clear();
            foreach(string port in SerialPort.GetPortNames())
            {
                PortCB.Items.Add(port);
            }
        }

        private void GetMouseLatency(object sender, EventArgs e)
        {
            CheckMouseLat();
        }

        private void RemoveFromSave(object sender, EventArgs e)
        {
            if(SaveNameBox.TextLength > 0)
            {
                foreach (Label item in SavesPanel.Controls.OfType<Label>())
                {
                    if (item.Text == SaveNameBox.Text)
                    {
                        //SavesPanel.Controls.Remove(item);
                        for (int i = 0; i < 3; i++) {
                            SavesPanel.Controls.Remove(SavesPanel.GetNextControl(item, true));
                            //SavesPanel.Controls.RemoveAt(SavesPanel.Controls.(SavesPanel.GetPositionFromControl(item)));
                        }
                        SavesPanel.Controls.Remove(item);
                        SavesPanel.RowCount--;
                    }
                }
            }
        }
    }
    }

