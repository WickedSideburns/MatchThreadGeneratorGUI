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
    public partial class InputError : Form
    {
        private string ErrorMsg;
        public InputError(string s)
        {
            ErrorMsg = s;
            InitializeComponent();
        }

        private void InputError_Load(object sender, EventArgs e)
        {
            this.ErrOutput.Text = ErrorMsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
