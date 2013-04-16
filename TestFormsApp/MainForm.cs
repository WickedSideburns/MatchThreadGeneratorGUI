// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns
// </copyright>
// <summary>
//   Defines the MainForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
	using System;
	using System.Windows.Forms;

	/// <summary>
	/// The main form.
	/// </summary>
	public partial class MainForm : Form
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm()
        {
            this.InitializeComponent();
        }

		/// <summary>
		/// The check box 1 checked changed.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void CheckBox1CheckedChanged(object sender, EventArgs e)
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

		/// <summary>
		/// The main form loaded.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void MainFormLoaded(object sender, EventArgs e)
        {
            this.NameTag.Enabled = false;
            this.NameText.Enabled = false;
            this.radioHome.Checked = true;
            this.radioHome.Enabled = false;
            this.radioVisiting.Enabled = false;
            this.CPCheck.Enabled = false;
        }

		/// <summary>
		/// The button 1_ click.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void GenerateThreadClicked(object sender, EventArgs e)
        {
            if (this.MapInput.Text == string.Empty)
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
            {
	            info.Home = this.radioHome.Checked;
            }

            if (this.CPCheck.Enabled)
            {
	            info.Set5Cp(this.CPCheck.Checked);
            }
            
            var outputForm = new OutputForm(info);
            outputForm.Show();
        }

		/// <summary>
		/// The map input enter.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void MapInputEnter(object sender, EventArgs e)
        {
            string happy = this.MapInput.Text;
            if (happy.Length < 4)
            {
	            return;
            }

            if (happy.Substring(0, 3) == "cp_")
            {
	            this.CPCheck.Enabled = true;
            }
            else
            {
	            this.CPCheck.Enabled = false;
            }
        }

		/// <summary>
		/// The map input text changed.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void MapInputTextChanged(object sender, EventArgs e)
        {
            string happy = this.MapInput.Text;
            if (happy.Length < 4)
            {
	            return;
            }

            if (happy.Substring(0, 3) == "cp_")
            {
	            this.CPCheck.Enabled = true;
            }
            else
            {
	            this.CPCheck.Enabled = false;
            }
        }
    }
}
