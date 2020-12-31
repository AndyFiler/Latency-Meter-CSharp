
namespace LatencyMeterCSharp
{
    partial class IntegratedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.MouseLat = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AvgSysLat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinSysLat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SysLat = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 110);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.MinMouseLat);
            this.panel5.Location = new System.Drawing.Point(154, 42);
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
            this.panel9.Location = new System.Drawing.Point(303, 42);
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
            this.panel7.Location = new System.Drawing.Point(303, 7);
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
            this.panel6.Location = new System.Drawing.Point(154, 77);
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
            this.panel8.Location = new System.Drawing.Point(303, 77);
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
            this.panel4.Location = new System.Drawing.Point(154, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 26);
            this.panel4.TabIndex = 11;
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
            // MouseLat
            // 
            this.MouseLat.AutoSize = true;
            this.MouseLat.Location = new System.Drawing.Point(-3, 13);
            this.MouseLat.Name = "MouseLat";
            this.MouseLat.Size = new System.Drawing.Size(26, 13);
            this.MouseLat.TabIndex = 4;
            this.MouseLat.Text = "0ms";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.AvgSysLat);
            this.panel3.Location = new System.Drawing.Point(5, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 26);
            this.panel3.TabIndex = 11;
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
            // AvgSysLat
            // 
            this.AvgSysLat.AutoSize = true;
            this.AvgSysLat.Location = new System.Drawing.Point(-3, 13);
            this.AvgSysLat.Name = "AvgSysLat";
            this.AvgSysLat.Size = new System.Drawing.Size(26, 13);
            this.AvgSysLat.TabIndex = 8;
            this.AvgSysLat.Text = "0ms";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MinSysLat);
            this.panel2.Location = new System.Drawing.Point(5, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 26);
            this.panel2.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SysLat);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 26);
            this.panel1.TabIndex = 11;
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
            // SysLat
            // 
            this.SysLat.AutoSize = true;
            this.SysLat.Location = new System.Drawing.Point(0, 13);
            this.SysLat.Name = "SysLat";
            this.SysLat.Size = new System.Drawing.Size(26, 13);
            this.SysLat.TabIndex = 3;
            this.SysLat.Text = "0ms";
            // 
            // IntegratedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(449, 110);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntegratedForm";
            this.Opacity = 0.75D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MinMouseLat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label MinPCLat;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label PCLat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MouseLat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinSysLat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SysLat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AvgMouseLat;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label AvgPCLat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AvgSysLat;
    }
}