namespace TestFormsApp
{
    public class TeamInfo : ITeamInfo
    {
        public string TeamName { get; set; }


        public string TeamTag { get; set; }

        public string Leader { get; set; }

        TeamInfo(string Ne, string Tg)
        {
            this.TeamName = Ne;
            this.TeamTag = Tg;
            this.Leader = null;
        }

		TeamInfo()
		{
			this.TeamName = string.Empty;
            this.TeamTag = string.Empty;
            this.Leader = null;
        }
    }
}