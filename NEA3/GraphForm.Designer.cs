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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.yAxis = new System.Windows.Forms.TextBox();
            this.xAxis = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.xAxis);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1155, 552);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
            // 
            // yAxis
            // 
            this.yAxis.BackColor = System.Drawing.SystemColors.Control;
            this.yAxis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yAxis.Location = new System.Drawing.Point(572, 558);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(43, 13);
            this.yAxis.TabIndex = 1;
            this.yAxis.Text = "Time";
            // 
            // xAxis
            // 
            this.xAxis.BackColor = System.Drawing.SystemColors.Control;
            this.xAxis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xAxis.Location = new System.Drawing.Point(3, 12);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(43, 13);
            this.xAxis.TabIndex = 0;
            this.xAxis.Text = "Speed";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 653);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.mainPanel);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox xAxis;
        private System.Windows.Forms.TextBox yAxis;
    }
}