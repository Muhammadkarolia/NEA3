namespace NEA3
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
            this.mainPanel = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.xforceLabel = new System.Windows.Forms.Label();
            this.YStartForce1 = new System.Windows.Forms.TextBox();
            this.XStartForce1 = new System.Windows.Forms.TextBox();
            this.yforceLabel = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Mass1tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mass2tb = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.IsValuesCorrect = new System.Windows.Forms.TextBox();
            this.ValueUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.XStartForce2 = new System.Windows.Forms.TextBox();
            this.YStartForce2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m1Y = new System.Windows.Forms.TextBox();
            this.m2Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m1X = new System.Windows.Forms.TextBox();
            this.m2X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LocationUpdate = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.propertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(9, 8);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(771, 569);
            this.mainPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainPanel.TabIndex = 34;
            this.mainPanel.TabStop = false;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(0, 539);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(208, 27);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // xforceLabel
            // 
            this.xforceLabel.AutoSize = true;
            this.xforceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.xforceLabel.Location = new System.Drawing.Point(5, 39);
            this.xforceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xforceLabel.Name = "xforceLabel";
            this.xforceLabel.Size = new System.Drawing.Size(50, 13);
            this.xforceLabel.TabIndex = 18;
            this.xforceLabel.Text = "X Force: ";
            // 
            // YStartForce1
            // 
            this.YStartForce1.Location = new System.Drawing.Point(58, 60);
            this.YStartForce1.Margin = new System.Windows.Forms.Padding(2);
            this.YStartForce1.Name = "YStartForce1";
            this.YStartForce1.Size = new System.Drawing.Size(152, 20);
            this.YStartForce1.TabIndex = 25;
            this.YStartForce1.Text = "1";
            // 
            // XStartForce1
            // 
            this.XStartForce1.Location = new System.Drawing.Point(58, 37);
            this.XStartForce1.Margin = new System.Windows.Forms.Padding(2);
            this.XStartForce1.Name = "XStartForce1";
            this.XStartForce1.Size = new System.Drawing.Size(152, 20);
            this.XStartForce1.TabIndex = 17;
            this.XStartForce1.Text = "-1";
            // 
            // yforceLabel
            // 
            this.yforceLabel.AutoSize = true;
            this.yforceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yforceLabel.Location = new System.Drawing.Point(5, 62);
            this.yforceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yforceLabel.Name = "yforceLabel";
            this.yforceLabel.Size = new System.Drawing.Size(50, 13);
            this.yforceLabel.TabIndex = 26;
            this.yforceLabel.Text = "Y Force: ";
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(110, 511);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(102, 21);
            this.Stop.TabIndex = 16;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Mass1tb
            // 
            this.Mass1tb.Location = new System.Drawing.Point(54, 10);
            this.Mass1tb.Margin = new System.Windows.Forms.Padding(2);
            this.Mass1tb.Name = "Mass1tb";
            this.Mass1tb.Size = new System.Drawing.Size(134, 20);
            this.Mass1tb.TabIndex = 27;
            this.Mass1tb.Text = "1000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mass1: ";
            // 
            // Mass2tb
            // 
            this.Mass2tb.Location = new System.Drawing.Point(54, 92);
            this.Mass2tb.Margin = new System.Windows.Forms.Padding(2);
            this.Mass2tb.Name = "Mass2tb";
            this.Mass2tb.Size = new System.Drawing.Size(134, 20);
            this.Mass2tb.TabIndex = 29;
            this.Mass2tb.Text = "100000000000";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(3, 511);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 21);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mass2:";
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesPanel.Controls.Add(this.LocationUpdate);
            this.propertiesPanel.Controls.Add(this.IsValuesCorrect);
            this.propertiesPanel.Controls.Add(this.ValueUpdate);
            this.propertiesPanel.Controls.Add(this.label3);
            this.propertiesPanel.Controls.Add(this.XStartForce2);
            this.propertiesPanel.Controls.Add(this.YStartForce2);
            this.propertiesPanel.Controls.Add(this.label10);
            this.propertiesPanel.Controls.Add(this.m1Y);
            this.propertiesPanel.Controls.Add(this.m2Y);
            this.propertiesPanel.Controls.Add(this.label9);
            this.propertiesPanel.Controls.Add(this.label8);
            this.propertiesPanel.Controls.Add(this.label7);
            this.propertiesPanel.Controls.Add(this.label5);
            this.propertiesPanel.Controls.Add(this.m1X);
            this.propertiesPanel.Controls.Add(this.m2X);
            this.propertiesPanel.Controls.Add(this.label6);
            this.propertiesPanel.Controls.Add(this.label4);
            this.propertiesPanel.Controls.Add(this.label1);
            this.propertiesPanel.Controls.Add(this.Start);
            this.propertiesPanel.Controls.Add(this.Mass2tb);
            this.propertiesPanel.Controls.Add(this.label2);
            this.propertiesPanel.Controls.Add(this.Mass1tb);
            this.propertiesPanel.Controls.Add(this.Stop);
            this.propertiesPanel.Controls.Add(this.yforceLabel);
            this.propertiesPanel.Controls.Add(this.XStartForce1);
            this.propertiesPanel.Controls.Add(this.YStartForce1);
            this.propertiesPanel.Controls.Add(this.xforceLabel);
            this.propertiesPanel.Controls.Add(this.Reset);
            this.propertiesPanel.Location = new System.Drawing.Point(793, 8);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(213, 569);
            this.propertiesPanel.TabIndex = 33;
            // 
            // IsValuesCorrect
            // 
            this.IsValuesCorrect.BackColor = System.Drawing.SystemColors.Control;
            this.IsValuesCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IsValuesCorrect.Location = new System.Drawing.Point(10, 306);
            this.IsValuesCorrect.Name = "IsValuesCorrect";
            this.IsValuesCorrect.Size = new System.Drawing.Size(200, 13);
            this.IsValuesCorrect.TabIndex = 56;
            // 
            // ValueUpdate
            // 
            this.ValueUpdate.Location = new System.Drawing.Point(8, 280);
            this.ValueUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ValueUpdate.Name = "ValueUpdate";
            this.ValueUpdate.Size = new System.Drawing.Size(102, 21);
            this.ValueUpdate.TabIndex = 55;
            this.ValueUpdate.Text = "Update Values";
            this.ValueUpdate.UseVisualStyleBackColor = true;
            this.ValueUpdate.Click += new System.EventHandler(this.ValueUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Y Force: ";
            // 
            // XStartForce2
            // 
            this.XStartForce2.Location = new System.Drawing.Point(54, 114);
            this.XStartForce2.Margin = new System.Windows.Forms.Padding(2);
            this.XStartForce2.Name = "XStartForce2";
            this.XStartForce2.Size = new System.Drawing.Size(152, 20);
            this.XStartForce2.TabIndex = 51;
            this.XStartForce2.Text = "0";
            // 
            // YStartForce2
            // 
            this.YStartForce2.Location = new System.Drawing.Point(54, 137);
            this.YStartForce2.Margin = new System.Windows.Forms.Padding(2);
            this.YStartForce2.Name = "YStartForce2";
            this.YStartForce2.Size = new System.Drawing.Size(152, 20);
            this.YStartForce2.TabIndex = 53;
            this.YStartForce2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(1, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "X Force: ";
            // 
            // m1Y
            // 
            this.m1Y.Location = new System.Drawing.Point(110, 208);
            this.m1Y.Margin = new System.Windows.Forms.Padding(2);
            this.m1Y.Name = "m1Y";
            this.m1Y.Size = new System.Drawing.Size(41, 20);
            this.m1Y.TabIndex = 49;
            // 
            // m2Y
            // 
            this.m2Y.Location = new System.Drawing.Point(110, 231);
            this.m2Y.Margin = new System.Windows.Forms.Padding(2);
            this.m2Y.Name = "m2Y";
            this.m2Y.Size = new System.Drawing.Size(41, 20);
            this.m2Y.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(121, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(67, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(76, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Positions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(5, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Mass2:";
            // 
            // m1X
            // 
            this.m1X.Location = new System.Drawing.Point(58, 206);
            this.m1X.Margin = new System.Windows.Forms.Padding(2);
            this.m1X.Name = "m1X";
            this.m1X.Size = new System.Drawing.Size(41, 20);
            this.m1X.TabIndex = 42;
            // 
            // m2X
            // 
            this.m2X.Location = new System.Drawing.Point(58, 229);
            this.m2X.Margin = new System.Windows.Forms.Padding(2);
            this.m2X.Name = "m2X";
            this.m2X.Size = new System.Drawing.Size(41, 20);
            this.m2X.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(5, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mass1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LocationUpdate
            // 
            this.LocationUpdate.Location = new System.Drawing.Point(8, 255);
            this.LocationUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.LocationUpdate.Name = "LocationUpdate";
            this.LocationUpdate.Size = new System.Drawing.Size(102, 21);
            this.LocationUpdate.TabIndex = 57;
            this.LocationUpdate.Text = "Update Locations";
            this.LocationUpdate.UseVisualStyleBackColor = true;
            this.LocationUpdate.Click += new System.EventHandler(this.LocationUpdate_Click);
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.Black;
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.locationBox.Location = new System.Drawing.Point(12, 12);
            this.locationBox.Multiline = true;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(147, 53);
            this.locationBox.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 585);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.propertiesPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label xforceLabel;
        private System.Windows.Forms.TextBox YStartForce1;
        private System.Windows.Forms.TextBox XStartForce1;
        private System.Windows.Forms.Label yforceLabel;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox Mass1tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mass2tb;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m1Y;
        private System.Windows.Forms.TextBox m2Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m1X;
        private System.Windows.Forms.TextBox m2X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox XStartForce2;
        private System.Windows.Forms.TextBox YStartForce2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ValueUpdate;
        private System.Windows.Forms.TextBox IsValuesCorrect;
        private System.Windows.Forms.Button LocationUpdate;
        private System.Windows.Forms.TextBox locationBox;
    }
}

