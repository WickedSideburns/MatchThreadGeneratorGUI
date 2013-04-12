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
    public partial class Form2 : Form
    {
        public Form2(string s)
        {
            
            InitializeComponent();
            james = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = james;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string james;
    }
}
