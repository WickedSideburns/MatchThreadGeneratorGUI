// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMatchInfo.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns  
// </copyright>
// <summary>
//   Defines the IMatchInfo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
    using System;

	/// <summary>
	/// The MatchInfo interface.
	/// </summary>
	public interface IMatchInfo
    {
		/// <summary>
		/// Gets or sets the opponent.
		/// </summary>
		TeamInfo Opponent { get; set; }

		/// <summary>
		/// Gets or sets the map name.
		/// </summary>
		string MapName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether know team.
		/// </summary>
		bool KnowTeam { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether date confirmed.
		/// </summary>
		bool DateConfirmed { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether home.
		/// </summary>
		bool Home { get; set; }

		/// <summary>
		/// Gets or sets the match date.
		/// </summary>
		DateTime MatchDate { get; set; }

		/// <summary>
		/// Gets the map type.
		/// </summary>
		string MapType { get; }

		/// <summary>
		/// The to reddit match thread.
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		string ToRedditMatchThread();

		/// <summary>
		/// The set 5 cp.
		/// </summary>
		/// <param name="b">
		/// The b.
		/// </param>
		void Set5Cp(bool b);
    }
}