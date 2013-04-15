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
	    private readonly IMatchInfo info;

	    public Form2(IMatchInfo info)
        {
	        this.info = info;

	        InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.tbInfo.Text = this.info.ToRedditMatchThread();
        }
    }
}
