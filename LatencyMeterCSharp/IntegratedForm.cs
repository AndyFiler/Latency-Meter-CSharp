using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace LatencyMeterCSharp
{
    public partial class IntegratedForm : Form
    {
        public IntegratedForm()
        {
            InitializeComponent();
            foreach(Control ctrl in this.Controls)
            {
                ctrl.MouseDown += IntegratedForms_MouseDown; 
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void IntegratedForms_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void UpdateData()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            SysLat.Text = ((GameIntegratedLatencyMeter.Form1)f).SysLat.Text;
            MinSysLat.Text = ((GameIntegratedLatencyMeter.Form1)f).MinSysLat.Text;
            AvgSysLat.Text = ((GameIntegratedLatencyMeter.Form1)f).AvgSysLat.Text;
            MouseLat.Text = ((GameIntegratedLatencyMeter.Form1)f).MouseLat.Text;
            MinMouseLat.Text = ((GameIntegratedLatencyMeter.Form1)f).MinMouseLat.Text;
            AvgMouseLat.Text = ((GameIntegratedLatencyMeter.Form1)f).AvgMouseLat.Text;
            PCLat.Text = ((GameIntegratedLatencyMeter.Form1)f).PCLat.Text;
            MinPCLat.Text = ((GameIntegratedLatencyMeter.Form1)f).MinPCLat.Text;
            AvgPCLat.Text = ((GameIntegratedLatencyMeter.Form1)f).AvgPCLat.Text;
        }
    }
}
