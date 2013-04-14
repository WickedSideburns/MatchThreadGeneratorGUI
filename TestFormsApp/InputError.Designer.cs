namespace TestFormsApp
{
    partial class InputError
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
            this.ErrOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrOutput
            // 
            this.ErrOutput.AutoSize = true;
            this.ErrOutput.Location = new System.Drawing.Point(56, 19);
            this.ErrOutput.Name = "ErrOutput";
            this.ErrOutput.Size = new System.Drawing.Size(35, 13);
            this.ErrOutput.TabIndex = 0;
            this.ErrOutput.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrOutput);
            this.Name = "InputError";
            this.Text = "Input Error";
            this.Load += new System.EventHandler(this.InputError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrOutput;
        private System.Windows.Forms.Button button1;
    }
}