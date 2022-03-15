using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Challenge_Repository.Classes
{
    public class DevTeam
    {
        public List<Developer> Developer { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public DevTeam() { }
        public DevTeam(int teamID)
        {
            TeamID = teamID;
        }
        public DevTeam(int teamID, string teamName) : this(teamID)
        {
            TeamName = teamName;
        }
        public DevTeam(int teamID, string teamName, List<Developer> developer) : this(teamID,teamName)
        {
            Developer = developer;
        }
       







    }
}
