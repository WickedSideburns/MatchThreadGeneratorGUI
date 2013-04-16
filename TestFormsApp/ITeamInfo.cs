// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamInfo.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns
// </copyright>
// <summary>
//   Defines the ITeamInfo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
    /*
        TeamInfo Class
     * Contains three string objects
     *  Team Name
     *  Team Tag
     *  Team Leader
     *  

     * 
     *
     * 
     */

	/// <summary>
	/// The TeamInfo interface.
	/// </summary>
	public interface ITeamInfo
    {
		/// <summary>
		/// Gets or sets the team name.
		/// </summary>
		string TeamName { get; set; }

		/// <summary>
		/// Gets or sets the team tag.
		/// </summary>
		string TeamTag { get; set; }

		/// <summary>
		/// Gets or sets the leader. Leader isn't needed for the Match Thread generator
		/// </summary>
		/// <remarks>
		/// Leader isn't needed for the Match Thread generator
		/// Possibly make it NULL?
		/// Possibly encapsulate it into its own object?
		/// Far in the future and too complicated. But, while I am thinking about it.
		/// Possible future Team Leader info would contain
		///     Steam Alias
		///     steam ID (or url)
		///     Description (as in, handles scrims/servers/roster management etc.)
		///   Possibly need multiple leaders (Make it an array?)
		///   Possibly add in a league? (silver, gold, steel)
		/// </remarks>
		string Leader { get; set; }
        
    }
}