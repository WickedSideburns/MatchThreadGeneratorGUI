namespace TestFormsApp
{
    public class TeamInfo : ITeamInfo
    {
        public string TeamName
        {
            get
            {
                return TeamName;
            }
            set
            {
                TeamName = value;
            }
        }

        public string TeamTag
        {
            get
            {
                return TeamTag;
            }
            set
            {
                TeamTag = value;
            }
        }

        public string Leader
        {
            get
            {
                return Leader;
            }
            set
            {
                Leader = value;
            }
        }

        TeamInfo(string Ne, string Tg)
        {
            TeamName = Ne;
            TeamTag = Tg;
            Leader = null;
        }
        TeamInfo()
        {
            TeamName = "";
            TeamTag = "";
            Leader = null;
        }
    }
}