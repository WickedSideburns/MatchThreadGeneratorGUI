﻿namespace TestFormsApp
{
    partial class Form2
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
			this.tbInfo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbInfo
			// 
			this.tbInfo.Location = new System.Drawing.Point(13, 13);
			this.tbInfo.Multiline = true;
			this.tbInfo.Name = "tbInfo";
			this.tbInfo.Size = new System.Drawing.Size(259, 237);
			this.tbInfo.TabIndex = 0;
			// 
			// Form2
			// 
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tbInfo);
			this.Name = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbInfo;
    }
}