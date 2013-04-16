// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatchInfo.cs" company="WickedSidburns Wicked Company">
//   WickedSideburns
// </copyright>
// <summary>
//   The match info.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestFormsApp
{
    using System;
    using System.Text;

	/// <summary>
	/// The match info.
	/// </summary>
	public class MatchInfo : IMatchInfo
    {
		/// <summary>
		/// The mapname.
		/// </summary>
		private string mapname;

		/// <summary>
		/// Initializes a new instance of the <see cref="MatchInfo"/> class.
		/// </summary>
		public MatchInfo()
		{
			this.Opponent = null;
		}

		/// <summary>
		/// Gets or sets the map name.
		/// </summary>
		/// <remarks>
		/// Using the default set accessor for MapName was causing a recursive function.
		/// Stack overflow suggested using the default set (but, I wanted to alter stuff so that couldn't happen. I guess).
		/// It suggested as an alternative to create a private variable and just have the accessors mess with that.
		/// Feel free to change
		/// --Wicked
		/// </remarks>
		public string MapName
        {
            get
            {
                return this.mapname;
            }

            set
            {
                this.mapname = value.ToLower();
                
				// The following changes the map type depending on the map name given.
                if (string.IsNullOrEmpty(this.mapname))
                {
	                return;
                }

                if (this.mapname.Contains("pl_"))
                {
	                this.MapType = "pl_";
                }
                else if (this.mapname.Contains("koth_"))
                {
	                this.MapType = "koth_";
                }
                else if (this.mapname.Contains("cp_"))
				{
					// This does not take into factor a 5cp . That will have to be worked on.
					this.MapType = "cp_"; 
				}
                else if (this.mapname.Contains("ctf_"))
                {
	                this.MapType = "ctf_";
                }
				else
                {
	                // Means unknown. Potential for handling dom_ or plr_ or other type variants
					this.MapType = "uk_";
				}
            }
        }

		/// <summary>
		/// Gets or sets the opponent.
		/// </summary>
		public TeamInfo Opponent { get; set; }

	    /// <summary>
	    /// Gets or sets a value indicating whether know team.
	    /// </summary>
	    public bool KnowTeam { get; set; }

	    /// <summary>
	    /// Gets or sets a value indicating whether date confirmed.
	    /// </summary>
	    public bool DateConfirmed { get; set; }

	    /// <summary>
	    /// Gets or sets a value indicating whether home.
	    /// </summary>
	    public bool Home { get; set; }

	    /// <summary>
	    /// Gets or sets the match date.
	    /// </summary>
	    public DateTime MatchDate { get; set; }

	    /// <summary>
	    /// Gets or sets the map type.
	    /// </summary>
	    public string MapType { get; protected set; }

	    /// <summary>
	    /// Generates a pastable string into a reddit post based on the entered information.
	    /// </summary>
	    /// <returns>
	    /// The <see cref="string"/>.
	    /// </returns>
	    public string ToRedditMatchThread()
        {
            const string LineSeg = "---------------------------";
            string[] roles = { "Pyro", "Scout", "Soldier", "Demo", "Engineer", "Medic", "Sniper", "Spy", "Heavy", "Backup" };

            var result = new StringBuilder();

		    result.Append("**MATCH INFO**");
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    if (this.KnowTeam)
		    {
			    result.Append("Our opposing team is ");
			    result.Append(this.Opponent.TeamName);
			    result.Append("(");
			    result.Append(this.Opponent.TeamTag);
			    result.Append(").");

			    if (!this.Home)
			    {
				    result.Append("We will be the visiting team.");
			    }
			    else
			    {
				    result.Append("We will be the home team.");
			    }
		    }
		    else
		    {
			    result.Append("Our enemy team is unknown.");
		    }

            result.Append(Environment.NewLine);
            result.Append(Environment.NewLine);

            result.Append("The time and date is ");
            result.Append(this.MatchDate.ToString("D"));
            if (this.DateConfirmed)
            {
	            result.Append(" These date and times are the tentative for now.");
            }

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);
		    result.Append(LineSeg);
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append("**ROLL CALL**");
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);
		    
			for (int i = 0; i < 10; i++)
		    {
                result.Append("* **");
                result.Append(roles[i]);
                result.Append("** - ");
                result.Append(Environment.NewLine);
            }

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);
		    result.Append(LineSeg);
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append("* **Not Available** - ");
            result.Append(Environment.NewLine);
            result.Append("* **Groupie** - ");
            result.Append(Environment.NewLine);

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);
		    result.Append(LineSeg);
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append("**MAP RESOURCES AND INFO**");
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

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
            {
	            result.Append("The map is unknown at the moment.");
            }

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append("Check out the [Scrim Thread]() here!");

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);
		    result.Append(LineSeg);
		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    result.Append("**INSPIRATIONAL WORDS/BEATS**");

		    result.Append(Environment.NewLine);
		    result.Append(Environment.NewLine);

		    return result.ToString();
        }

	    /// <summary>
	    /// The set 5 cp.
	    /// </summary>
	    /// <param name="b">
	    /// The b.  Wicked: what does 'b' do here?
	    /// </param>
	    public void Set5Cp(bool b)
        {
            if (this.MapType != "cp_" && this.MapType != "5cp_")
            {
				// not applicable.
	            return;
            }

            if (b)
            {
	            this.MapType = "5cp_";
            }
            else
            {
	            this.MapType = "cp_";
            }
        }
    }
}