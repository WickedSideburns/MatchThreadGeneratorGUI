namespace TestFormsApp
{
    using System;
    using System.Text;

    public class MatchInfo : IMatchInfo
    {
        public TeamInfo Opponent { get; set; }

        /*
            Using the default set accessor for MapName was causing a recursive function.
         * Stack overflow suggested using the default set (but, I wanted to alter stuff so that couldn't happen. I guess).
         * It suggested as an alternative to create a private variable and just have the accessors mess with that.
         * Feel free to change
         * 
         * --Wicked
         */
        private string _mapname;

        public string MapName
        {
            get
            {
                return _mapname;
            }
            set
            {
                _mapname = value;
                //The following changes the map type depending on the map name given.

                if (string.IsNullOrEmpty(MapName))
                    return;

                if (MapName.ToLower().Contains("pl_"))
                    MapType = "pl_";
                else if (MapName.ToLower().Contains("koth_"))
                    MapType = "koth_";
                else if (MapName.ToLower().Contains("cp_"))
                    MapType = "cp_"; //This does not take into factor a 5cp . That will have to be worked on.
                else if (MapName.ToLower().Contains("ctf_"))
                    MapType = "ctf_";
                else
                    MapType = "uk_";//Means unknown. Potential for handling dom_ or plr_ or other type variants
            }
        }

        public bool KnowTeam { get; set; }

        public bool DateConfirmed { get; set; }

        public bool Home { get; set; }

        public DateTime MatchDate { get; set; }

        public string MapType
        {
            get;
            protected set;
        }

        public MatchInfo()
        {
            Opponent = null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Team name: {0} ({1})", this.Opponent.TeamName, this.Opponent.TeamTag));
            sb.Append(Environment.NewLine);
            sb.Append(string.Format("MapName name: {0}", this.MapName));

            if (this.KnowTeam)
            {
                sb.Append(Environment.NewLine);
                sb.Append("We will be the ");
                if (this.Home)
                    sb.Append("Home ");
                else
                    sb.Append("visiting ");
                sb.Append("team.");
            }

            if (this.MapType == null || this.MapType == "")
                return sb.ToString();
            if (string.IsNullOrEmpty("pl_"))
            {
                sb.Append(Environment.NewLine);
                sb.Append("The map will be a payload map.");
            }

            return sb.ToString();
        }

        public string ToRedditMatchThread()
        {
            const string lineSeg = "---------------------------";
            string[] roles = { "Pyro", "Scout", "Soldier", "Demo", "Engineer", "Medic", "Sniper", "Spy", "Heavy", "Backup" };

            StringBuilder result = new StringBuilder();

            result.Append("**MATCH INFO**");
            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            if (this.KnowTeam)
            {
                result.Append("Our opposing team is ");
                result.Append(this.Opponent.TeamName);
                result.Append("("); result.Append(this.Opponent.TeamTag); result.Append(").");
                if (!this.Home)
                    result.Append("We will be the visiting team.");
                else
                    result.Append("We will be the home team.");
            }
            else
                result.Append("Our enemy team is unknown.");

            result.Append(Environment.NewLine);
            result.Append(Environment.NewLine);

            result.Append("The time and date is ");
            result.Append(this.MatchDate.ToString("D"));
            if (this.DateConfirmed)
                result.Append(" These date and times are the tentative for now.");

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);
            result.Append(lineSeg);
            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            result.Append("**ROLL CALL**"); result.Append(Environment.NewLine); result.Append(Environment.NewLine);
            for (int i = 0; i < 10; i++)
            {
                result.Append("* **");
                result.Append(roles[i]);
                result.Append("** - ");
                result.Append(Environment.NewLine);
            }

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);
            result.Append(lineSeg);
            result.Append(Environment.NewLine); result.Append(Environment.NewLine);


            result.Append("* **Not Available** - ");
            result.Append(Environment.NewLine);
            result.Append("* **Groupie** - ");
            result.Append(Environment.NewLine);

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);
            result.Append(lineSeg);
            result.Append(Environment.NewLine); result.Append(Environment.NewLine);


            result.Append("**MAP RESOURCES AND INFO**"); result.Append(Environment.NewLine); result.Append(Environment.NewLine);


            if (this.MapType == "5cp_")
            {
                result.Append("The map is ");
                result.Append(this.MapName);
                result.Append(", a 5cp map. The match will be determined with a best out of 5 with 30 minute halfs. This is standard for 5cp.");
            }
            else if (this.MapType == "cp_")
            {
                result.Append("The map is ");
                result.Append(this.MapName);
                result.Append(", an attack/defend map. The match will be played in an ABBA format, standard for attack/defend cp maps.");
            }
            else if (this.MapType == "ctf_")
            {
                result.Append("The map is ");
                result.Append(this.MapName);
                result.Append(", a capture the flag map. The first team to achieve 10 captures in two 20 minute rounds wins.");
            }
            else if (this.MapType == "koth_")
            {
                result.Append("The map is ");
                result.Append(this.MapName);
                result.Append(", a king of the hill map. The first team to win 4 rounds wins the match.");
            }
            else if (this.MapType == "pl_")
            {
                result.Append("The map is ");
                result.Append(this.MapName);
                result.Append(", a payload map. The map will be played in stop-watch ABBA format, with one team attacking and the other team defending.");
            }
            else
                result.Append("The map is unknown at the moment.");

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            result.Append("Check out the [Scrim Thread]() here!");

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);
            result.Append(lineSeg);
            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            result.Append("**INSPIRATIONAL WORDS/BEATS**");

            result.Append(Environment.NewLine); result.Append(Environment.NewLine);

            return result.ToString();
        }
    }
}