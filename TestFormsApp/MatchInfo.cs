namespace TestFormsApp
{
	using System;
	using System.Text;

	public class MatchInfo : IMatchInfo
	{
		public string TeamName { get; set; }

		public string MapName { get; set; }

		public bool KnowTeam { get; set; }

		public bool DateConfirmed { get; set; }

		public string TeamTag { get; set; }

		public DateTime MatchDate { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(string.Format("Team name: {0} ({1})", this.TeamName, this.TeamTag));
			sb.Append(Environment.NewLine);
			sb.Append(string.Format("MapName name: {0}", this.MapName));

			return sb.ToString();
		}
	}
}