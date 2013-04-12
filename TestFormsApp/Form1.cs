using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.NameTag.Enabled == false)
            {
                this.NameTag.Enabled = true;
                this.NameText.Enabled = true;
            }
            else
            {
                this.NameTag.Enabled = false;
                this.NameText.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.NameTag.Enabled = false;
            this.NameText.Enabled = false;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.NameTag.Enabled = false;
            this.NameTag.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gerry;
            gerry = MapInput.Text;
            var formz = new Form2(gerry);
            formz.Show();
        }
    }
}
