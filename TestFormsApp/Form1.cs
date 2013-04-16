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

            if (this.radioVisiting.Enabled == false)
            {
                this.radioVisiting.Enabled = true;
                this.radioHome.Enabled = true;
            }
            else
            {
                this.radioVisiting.Enabled = false;
                this.radioHome.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.NameTag.Enabled = false;
            this.NameText.Enabled = false;
            this.radioHome.Checked = true;
            this.radioHome.Enabled = false;
            this.radioVisiting.Enabled = false;
            this.CPCheck.Enabled = false;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.NameTag.Enabled = false;
            this.NameTag.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MapInput.Text == "")
            {
	            MessageBox.Show("Please enter a map!");
                return;
            }
	        var info = new MatchInfo
		                   {
			                   MatchDate = this.MatchDateInput.Value,
			                   DateConfirmed = this.DateCheck.Checked,
			                   MapName = this.MapInput.Text,
			                   KnowTeam = this.TeamCheck.Checked,
                               Opponent = new TeamInfo(this.NameText.Text, this.NameTag.Text),
                               
                               Home = true
		                   };

            if (info.KnowTeam)
                info.Home = this.radioHome.Checked;

            if (this.CPCheck.Enabled)
                info.Set5CP(CPCheck.Checked);
            
			
            var formz = new Form2(info);
            formz.Show();
        }

        private void DateCheck_CheckedChanged(object sender, EventArgs e)
        {
			
        }

        private void MapInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MapInput_Enter(object sender, EventArgs e)
        {
            string happy = this.MapInput.Text;
            if (happy.Length < 4)
                return;
            if (happy.Substring(0, 3) == "cp_")
                this.CPCheck.Enabled = true;
            else
                this.CPCheck.Enabled = false;
        }

        private void MapInput_TextChanged_1(object sender, EventArgs e)
        {
            string happy = MapInput.Text;
            if (happy.Length < 4)
                return;
            if (happy.Substring(0, 3) == "cp_")
                this.CPCheck.Enabled = true;
            else
                this.CPCheck.Enabled = false;
        }
    }
}
