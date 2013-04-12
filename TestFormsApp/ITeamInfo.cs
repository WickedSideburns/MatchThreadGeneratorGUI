namespace TestFormsApp
{
    /*
        TeamInfo Class
     * Contains three string objects
     *  Team Name
     *  Team Tag
     *  Team Leader
     *  
     * Leader isn't needed for the Match Thread generator
     *  Possibly make it NULL?
     *  POssibly encapsulate it into its own object?
     *      Far in the future and too complicated. But, while I am thinking about it.
     *      Possible future Team Leader info would contain
     *          Steam Alias
     *          steam ID (or url)
     *          Description (as in, handles scrims/servers/roster management etc.)
     *  Possibly need multiple leaders (Make it an array?)
     * Possibly add in a league? (silver, gold, steel)
     * 
     *
     * 
     */
    public interface ITeamInfo
    {
        string TeamName { get; set; }
        string TeamTag { get; set; }
        string Leader { get; set; }
        
    }
}