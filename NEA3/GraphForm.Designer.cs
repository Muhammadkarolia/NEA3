namespace NEA3
{
    partial class GraphForm
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
            this.mass1Panel = new System.Windows.Forms.Panel();
            this.xAxis = new System.Windows.Forms.TextBox();
            this.mass2Panel = new System.Windows.Forms.Panel();
            this.yAxis = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mass1Panel
            // 
            this.mass1Panel.Location = new System.Drawing.Point(1, 0);
            this.mass1Panel.Name = "mass1Panel";
            this.mass1Panel.Size = new System.Drawing.Size(1154, 600);
            this.mass1Panel.TabIndex = 0;
            this.mass1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel1);
            // 
            // xAxis
            // 
            this.xAxis.BackColor = System.Drawing.SystemColors.Control;
            this.xAxis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xAxis.Location = new System.Drawing.Point(1, 0);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(43, 13);
            this.xAxis.TabIndex = 0;
            this.xAxis.Text = "Speed";
            // 
            // mass2Panel
            // 
            this.mass2Panel.Location = new System.Drawing.Point(1, 3);
            this.mass2Panel.Name = "mass2Panel";
            this.mass2Panel.Size = new System.Drawing.Size(1152, 597);
            this.mass2Panel.TabIndex = 1;
            this.mass2Panel.Visible = false;
            this.mass2Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel2);
            // 
            // yAxis
            // 
            this.yAxis.BackColor = System.Drawing.SystemColors.Control;
            this.yAxis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yAxis.Location = new System.Drawing.Point(604, 606);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(43, 13);
            this.yAxis.TabIndex = 1;
            this.yAxis.Text = "Time";
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(1021, 606);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(122, 23);
            this.Change.TabIndex = 0;
            this.Change.Text = "Change mass ";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 653);
            this.Controls.Add(this.mass2Panel);
            this.Controls.Add(this.xAxis);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.mass1Panel);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mass1Panel;
        private System.Windows.Forms.TextBox xAxis;
        private System.Windows.Forms.TextBox yAxis;
        private System.Windows.Forms.Panel mass2Panel;
        private System.Windows.Forms.Button Change;
    }
}