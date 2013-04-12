﻿namespace TestFormsApp
{
	using System;

	public interface IMatchInfo
	{
		string TeamName { get; set; }
		string MapName { get; set; }
		bool KnowTeam { get; set; }
		bool DateConfirmed { get; set; }
		string TeamTag { get; set; }
		DateTime MatchDate { get; set; }
	}
}