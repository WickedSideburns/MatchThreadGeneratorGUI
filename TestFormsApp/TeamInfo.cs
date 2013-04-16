// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamInfo.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns
// </copyright>
// <summary>
//   The team info.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
	/// <summary>
	/// The team info.
	/// </summary>
	public class TeamInfo : ITeamInfo
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="TeamInfo"/> class.
		/// </summary>
		/// <param name="teamName">
		/// The team name.
		/// </param>
		/// <param name="teamTag">
		/// The team tag.
		/// </param>
		public TeamInfo(string teamName, string teamTag)
        {
            this.TeamName = teamName;
            this.TeamTag = teamTag;
            this.Leader = null;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="TeamInfo"/> class.
		/// </summary>
		public TeamInfo()
		{
			this.TeamName = string.Empty;
            this.TeamTag = string.Empty;
            this.Leader = null;
        }

		/// <summary>
		/// Gets or sets the team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Gets or sets the team tag.
		/// </summary>
		public string TeamTag { get; set; }

		/// <summary>
		/// Gets or sets the leader.
		/// </summary>
		public string Leader { get; set; }
    }
}