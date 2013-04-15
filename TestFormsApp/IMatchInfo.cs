namespace TestFormsApp
{
    using System;

    public interface IMatchInfo
    {
        TeamInfo Opponent { get; set; }
        string MapName { get; set; }
        bool KnowTeam { get; set; }
        bool DateConfirmed { get; set; }
        bool Home { get; set; }
        DateTime MatchDate { get; set; }
        string MapType { get; }
        string ToRedditMatchThread();
    }
}