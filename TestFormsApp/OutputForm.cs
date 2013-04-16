// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputForm.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns
// </copyright>
// <summary>
//   Defines the OutputForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
	using System;
	using System.Windows.Forms;

	/// <summary>
	/// The form 2.
	/// </summary>
	public partial class OutputForm : Form
    {
		/// <summary>
		/// The info.
		/// </summary>
		private readonly IMatchInfo info;

		/// <summary>
		/// Initializes a new instance of the <see cref="OutputForm"/> class.
		/// </summary>
		/// <param name="info">
		/// The info.
		/// </param>
		public OutputForm(IMatchInfo info)
        {
	        this.info = info;

	        this.InitializeComponent();
        }

		/// <summary>
		/// The form 2 load.
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private void Form2Load(object sender, EventArgs e)
        {
            this.tbInfo.Text = this.info.ToRedditMatchThread();
        }
    }
}
