namespace TestFormsApp
{
	using System;
	using System.Text;

	public class MatchInfo : IMatchInfo
	{
		public string TeamName { get; set; }

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
                if (MapName.Substring(0, 3).ToLower() == "pl_")
                    MapType = "pl_";
                else if (MapName.Substring(0, 5).ToLower() == "koth_")
                    MapType = "koth_";
                else if (MapName.Substring(0, 3).ToLower() == "cp_")
                    MapType = "cp_"; //This does not take into factor a 5cp . That will have to be worked on.
                else if (MapName.Substring(0, 4).ToLower() == "ctf_")
                    MapType = "ctf_";
                else
                    MapType = "uk_";//Means unknown. Potential for handling dom_ or plr_ or other type variants
            }
        }

		public bool KnowTeam { get; set; }

		public bool DateConfirmed { get; set; }

		public string TeamTag { get; set; }

		public DateTime MatchDate { get; set; }

        public string MapType
        {
            get;
            protected set;
        }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(string.Format("Team name: {0} ({1})", this.TeamName, this.TeamTag));
			sb.Append(Environment.NewLine);
			sb.Append(string.Format("MapName name: {0}", this.MapName));

            if (this.MapType == "pl_")
            {
                sb.Append(Environment.NewLine);
                sb.Append("The map will be a payload map.");
            }

			return sb.ToString();
		}
	}
}