namespace GameIntegratedLatencyMeter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SysLat = new System.Windows.Forms.Label();
            this.MouseLat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinSysLat = new System.Windows.Forms.Label();
            this.AvgSysLat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetDataButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MinMouseLat = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.MinPCLat = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PCLat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.AvgMouseLat = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AvgPCLat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PortCB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveNameBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SavesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IntegratedCheck = new System.Windows.Forms.CheckBox();
            this.DetectionZone = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Export = new System.Windows.Forms.Button();
            this.FileCB = new System.Windows.Forms.ComboBox();
            this.ExportName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RemoveSavedFile = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SavesPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(142, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.RunService);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Received);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Latency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mouse Latency:";
            // 
            // SysLat
            // 
            this.SysLat.AutoSize = true;
            this.SysLat.Location = new System.Drawing.Point(0, 13);
            this.SysLat.Name = "SysLat";
            this.SysLat.Size = new System.Drawing.Size(26, 13);
            this.SysLat.TabIndex = 3;
            this.SysLat.Text = "0ms";
            // 
            // MouseLat
            // 
            this.MouseLat.AutoSize = true;
            this.MouseLat.Location = new System.Drawing.Point(-3, 13);
            this.MouseLat.Name = "MouseLat";
            this.MouseLat.Size = new System.Drawing.Size(26, 13);
            this.MouseLat.TabIndex = 4;
            this.MouseLat.Text = "0ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min System Latency:";
            // 
            // MinSysLat
            // 
            this.MinSysLat.AutoSize = true;
            this.MinSysLat.Location = new System.Drawing.Point(-3, 13);
            this.MinSysLat.Name = "MinSysLat";
            this.MinSysLat.Size = new System.Drawing.Size(26, 13);
            this.MinSysLat.TabIndex = 6;
            this.MinSysLat.Text = "0ms";
            // 
            // AvgSysLat
            // 
            this.AvgSysLat.AutoSize = true;
            this.AvgSysLat.Location = new System.Drawing.Point(-3, 13);
            this.AvgSysLat.Name = "AvgSysLat";
            this.AvgSysLat.Size = new System.Drawing.Size(26, 13);
            this.AvgSysLat.TabIndex = 8;
            this.AvgSysLat.Text = "0ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Average System Latency:";
            // 
            // ResetDataButton
            // 
            this.ResetDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetDataButton.Location = new System.Drawing.Point(153, 169);
            this.ResetDataButton.Name = "ResetDataButton";
            this.ResetDataButton.Size = new System.Drawing.Size(142, 23);
            this.ResetDataButton.TabIndex = 9;
            this.ResetDataButton.Text = "Reset";
            this.ResetDataButton.UseVisualStyleBackColor = true;
            this.ResetDataButton.Click += new System.EventHandler(this.ResetData);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Start, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PortCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ResetDataButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 44);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.MinMouseLat);
            this.panel5.Location = new System.Drawing.Point(154, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(103, 26);
            this.panel5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Min Mouse Latency:";
            // 
            // MinMouseLat
            // 
            this.MinMouseLat.AutoSize = true;
            this.MinMouseLat.Location = new System.Drawing.Point(-3, 13);
            this.MinMouseLat.Name = "MinMouseLat";
            this.MinMouseLat.Size = new System.Drawing.Size(26, 13);
            this.MinMouseLat.TabIndex = 4;
            this.MinMouseLat.Text = "0ms";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.MinPCLat);
            this.panel9.Location = new System.Drawing.Point(303, 100);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 26);
            this.panel9.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Min PC Latency:";
            // 
            // MinPCLat
            // 
            this.MinPCLat.AutoSize = true;
            this.MinPCLat.Location = new System.Drawing.Point(0, 13);
            this.MinPCLat.Name = "MinPCLat";
            this.MinPCLat.Size = new System.Drawing.Size(26, 13);
            this.MinPCLat.TabIndex = 2;
            this.MinPCLat.Text = "0ms";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PCLat);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(303, 65);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(65, 26);
            this.panel7.TabIndex = 15;
            // 
            // PCLat
            // 
            this.PCLat.AutoSize = true;
            this.PCLat.Location = new System.Drawing.Point(0, 13);
            this.PCLat.Name = "PCLat";
            this.PCLat.Size = new System.Drawing.Size(26, 13);
            this.PCLat.TabIndex = 2;
            this.PCLat.Text = "0ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "PC Latency:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.AvgMouseLat);
            this.panel6.Location = new System.Drawing.Point(154, 135);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 26);
            this.panel6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Average Mouse Latency:";
            // 
            // AvgMouseLat
            // 
            this.AvgMouseLat.AutoSize = true;
            this.AvgMouseLat.Location = new System.Drawing.Point(-3, 13);
            this.AvgMouseLat.Name = "AvgMouseLat";
            this.AvgMouseLat.Size = new System.Drawing.Size(26, 13);
            this.AvgMouseLat.TabIndex = 4;
            this.AvgMouseLat.Text = "0ms";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.AvgPCLat);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(303, 135);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(108, 26);
            this.panel8.TabIndex = 14;
            // 
            // AvgPCLat
            // 
            this.AvgPCLat.AutoSize = true;
            this.AvgPCLat.Location = new System.Drawing.Point(-3, 13);
            this.AvgPCLat.Name = "AvgPCLat";
            this.AvgPCLat.Size = new System.Drawing.Size(26, 13);
            this.AvgPCLat.TabIndex = 2;
            this.AvgPCLat.Text = "0ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Average PC Latency:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.MouseLat);
            this.panel4.Location = new System.Drawing.Point(154, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 26);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.AvgSysLat);
            this.panel3.Location = new System.Drawing.Point(5, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 26);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MinSysLat);
            this.panel2.Location = new System.Drawing.Point(5, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 26);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SysLat);
            this.panel1.Location = new System.Drawing.Point(5, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 26);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(302, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StopService);
            // 
            // PortCB
            // 
            this.PortCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortCB.FormattingEnabled = true;
            this.PortCB.Location = new System.Drawing.Point(153, 4);
            this.PortCB.Name = "PortCB";
            this.PortCB.Size = new System.Drawing.Size(142, 21);
            this.PortCB.TabIndex = 18;
            this.PortCB.DropDown += new System.EventHandler(this.UpdatePorts);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(153, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Calculate Mouse Latency";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetMouseLatency);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(4, 199);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(142, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveCurrent);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.SaveNameBox);
            this.panel10.Location = new System.Drawing.Point(150, 196);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(121, 36);
            this.panel10.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Save Name:";
            // 
            // SaveNameBox
            // 
            this.SaveNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNameBox.Location = new System.Drawing.Point(3, 13);
            this.SaveNameBox.Name = "SaveNameBox";
            this.SaveNameBox.Size = new System.Drawing.Size(116, 20);
            this.SaveNameBox.TabIndex = 18;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(302, 199);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 23);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveFromSave);
            // 
            // SavesPanel
            // 
            this.SavesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavesPanel.BackColor = System.Drawing.Color.Gray;
            this.SavesPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SavesPanel.ColumnCount = 4;
            this.SavesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.10677F));
            this.SavesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.96441F));
            this.SavesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.96441F));
            this.SavesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.96441F));
            this.SavesPanel.Controls.Add(this.label13, 0, 0);
            this.SavesPanel.Controls.Add(this.label9, 3, 0);
            this.SavesPanel.Controls.Add(this.label8, 2, 0);
            this.SavesPanel.Controls.Add(this.label6, 1, 0);
            this.SavesPanel.Location = new System.Drawing.Point(492, 44);
            this.SavesPanel.MaximumSize = new System.Drawing.Size(5000, 300);
            this.SavesPanel.MinimumSize = new System.Drawing.Size(420, 125);
            this.SavesPanel.Name = "SavesPanel";
            this.SavesPanel.RowCount = 1;
            this.SavesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SavesPanel.Size = new System.Drawing.Size(500, 300);
            this.SavesPanel.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Min System Latency:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Average Mouse Latency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Average System Latency:";
            // 
            // IntegratedCheck
            // 
            this.IntegratedCheck.AutoSize = true;
            this.IntegratedCheck.BackColor = System.Drawing.Color.Gray;
            this.IntegratedCheck.Location = new System.Drawing.Point(26, 14);
            this.IntegratedCheck.Name = "IntegratedCheck";
            this.IntegratedCheck.Size = new System.Drawing.Size(105, 17);
            this.IntegratedCheck.TabIndex = 12;
            this.IntegratedCheck.Text = "Game Integrated";
            this.toolTip1.SetToolTip(this.IntegratedCheck, "In this mode the program will simulate mouse button click in game.  Position the " +
        "sensor in the place where the pixels will change the most after pressing left mo" +
        "use button (ex. muzzle flash)");
            this.IntegratedCheck.UseVisualStyleBackColor = false;
            // 
            // DetectionZone
            // 
            this.DetectionZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetectionZone.AutoSize = true;
            this.DetectionZone.BackColor = System.Drawing.Color.Black;
            this.DetectionZone.Location = new System.Drawing.Point(22, 416);
            this.DetectionZone.MaximumSize = new System.Drawing.Size(9700, 500);
            this.DetectionZone.Name = "DetectionZone";
            this.DetectionZone.Size = new System.Drawing.Size(970, 173);
            this.DetectionZone.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Export, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FileCB, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExportName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveSavedFile, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Import, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(492, 351);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(500, 300);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(350, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 59);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Export.Location = new System.Drawing.Point(3, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(119, 23);
            this.Export.TabIndex = 23;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.ExportData);
            // 
            // FileCB
            // 
            this.FileCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileCB.FormattingEnabled = true;
            this.FileCB.Location = new System.Drawing.Point(253, 32);
            this.FileCB.Name = "FileCB";
            this.FileCB.Size = new System.Drawing.Size(119, 21);
            this.FileCB.TabIndex = 22;
            this.FileCB.DropDown += new System.EventHandler(this.UpdateFiles);
            // 
            // ExportName
            // 
            this.ExportName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ExportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportName.Location = new System.Drawing.Point(128, 32);
            this.ExportName.Name = "ExportName";
            this.ExportName.Size = new System.Drawing.Size(119, 20);
            this.ExportName.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(253, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Select File:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(128, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "File Name:";
            // 
            // RemoveSavedFile
            // 
            this.RemoveSavedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSavedFile.Location = new System.Drawing.Point(378, 32);
            this.RemoveSavedFile.Name = "RemoveSavedFile";
            this.RemoveSavedFile.Size = new System.Drawing.Size(119, 24);
            this.RemoveSavedFile.TabIndex = 26;
            this.RemoveSavedFile.Text = "Remove";
            this.RemoveSavedFile.UseVisualStyleBackColor = true;
            this.RemoveSavedFile.Click += new System.EventHandler(this.RemoveData);
            // 
            // Import
            // 
            this.Import.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Import.Location = new System.Drawing.Point(378, 3);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(119, 23);
            this.Import.TabIndex = 25;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.ImportData);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Remember";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1016, 587);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.IntegratedCheck);
            this.Controls.Add(this.SavesPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DetectionZone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C# Latency Meter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.SavesPanel.ResumeLayout(false);
            this.SavesPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SysLat;
        private System.Windows.Forms.Label MouseLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinSysLat;
        private System.Windows.Forms.Label AvgSysLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetDataButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MinMouseLat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AvgMouseLat;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label MinPCLat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label PCLat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label AvgPCLat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel SavesPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SaveNameBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox IntegratedCheck;
        private System.Windows.Forms.Panel DetectionZone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Export;
        public System.Windows.Forms.ComboBox FileCB;
        private System.Windows.Forms.TextBox ExportName;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button RemoveSavedFile;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.ComboBox PortCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

