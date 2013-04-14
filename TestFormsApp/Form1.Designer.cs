﻿namespace TestFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.MatchDateInput = new System.Windows.Forms.DateTimePicker();
            this.MapInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioHome = new System.Windows.Forms.RadioButton();
            this.radioVisiting = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Match Date";
            // 
            // MatchDateInput
            // 
            this.MatchDateInput.Location = new System.Drawing.Point(234, 26);
            this.MatchDateInput.Name = "MatchDateInput";
            this.MatchDateInput.Size = new System.Drawing.Size(200, 20);
            this.MatchDateInput.TabIndex = 1;
            // 
            // MapInput
            // 
            this.MapInput.Location = new System.Drawing.Point(234, 109);
            this.MapInput.Name = "MapInput";
            this.MapInput.Size = new System.Drawing.Size(168, 20);
            this.MapInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Map File Name";
            // 
            // TeamCheck
            // 
            this.TeamCheck.AutoSize = true;
            this.TeamCheck.Location = new System.Drawing.Point(234, 152);
            this.TeamCheck.Name = "TeamCheck";
            this.TeamCheck.Size = new System.Drawing.Size(44, 17);
            this.TeamCheck.TabIndex = 4;
            this.TeamCheck.Text = "Yes";
            this.TeamCheck.UseVisualStyleBackColor = true;
            this.TeamCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you know the opposing team?";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(234, 192);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team Name:";
            // 
            // NameTag
            // 
            this.NameTag.Location = new System.Drawing.Point(234, 235);
            this.NameTag.Name = "NameTag";
            this.NameTag.Size = new System.Drawing.Size(100, 20);
            this.NameTag.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Team Tag:";
            // 
            // DateCheck
            // 
            this.DateCheck.AutoSize = true;
            this.DateCheck.Location = new System.Drawing.Point(234, 53);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(44, 17);
            this.DateCheck.TabIndex = 10;
            this.DateCheck.Text = "Yes";
            this.DateCheck.UseVisualStyleBackColor = true;
            this.DateCheck.CheckedChanged += new System.EventHandler(this.DateCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Confirmed?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirm Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Your team is: ";
            // 
            // radioHome
            // 
            this.radioHome.AutoSize = true;
            this.radioHome.Location = new System.Drawing.Point(234, 77);
            this.radioHome.Name = "radioHome";
            this.radioHome.Size = new System.Drawing.Size(53, 17);
            this.radioHome.TabIndex = 14;
            this.radioHome.TabStop = true;
            this.radioHome.Text = "Home";
            this.radioHome.UseVisualStyleBackColor = true;
            // 
            // radioVisiting
            // 
            this.radioVisiting.AutoSize = true;
            this.radioVisiting.Location = new System.Drawing.Point(349, 77);
            this.radioVisiting.Name = "radioVisiting";
            this.radioVisiting.Size = new System.Drawing.Size(58, 17);
            this.radioVisiting.TabIndex = 15;
            this.radioVisiting.TabStop = true;
            this.radioVisiting.Text = "Visiting";
            this.radioVisiting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 332);
            this.Controls.Add(this.radioVisiting);
            this.Controls.Add(this.radioHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapInput);
            this.Controls.Add(this.MatchDateInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Input Match Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MatchDateInput;
        private System.Windows.Forms.TextBox MapInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TeamCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox DateCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioHome;
        private System.Windows.Forms.RadioButton radioVisiting;
    }
}

