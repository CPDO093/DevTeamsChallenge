using DevTeams_Challenge_Repository.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DevTeams_Challenge_Repository
{
    public class DevTeamsRepo : DeveloperRepo
    {
        //This is our Repository class that will hold our directory (which will act as our database) and methods that will directly talk to our directory.

        private List<DevTeam> _devTeamDirectory = new List<DevTeam>();
       

        // C
       
        public bool AddDeveloperToTeamByID( int devId, int teamID)
        {
            Developer dev = GetDevById(devId);

            
            DevTeam dTeam = GetDevTeamById(teamID);
            if (dev != default && dTeam != default)
            {
                 int startingCoubt = dTeam.Developer.Count();
                 dTeam.Developer.Add(dev);
                 return dTeam.Developer.Count > startingCoubt ? true : false;

            }
            return false;
        }
        public bool AddNewDevTeam(DevTeam devT)
        { 
            if (devT != default)
            {
                int startingCount = _devTeamDirectory.Count();
                _devTeamDirectory.Add(devT);
                return _devTeamDirectory.Count > startingCount ? true : false;
            }
            return false;
        }
        
        // R

        public DevTeam GetDevTeamById(int teamID)
        {
            return _devTeamDirectory.Where(d => d.TeamID == teamID).SingleOrDefault();
        }

        public List<DevTeam> GetAllDevTeamsList(int dTeam)
        {
            return _devTeamDirectory.Where(t => t.TeamID == dTeam).ToList();
        }
        
        public DevTeam GetDevTeamByTeamName(string teamName)
        {
            return _devTeamDirectory.Where(tn => tn.TeamName == teamName).SingleOrDefault();
        }
        
        // U
        public bool UpdateExisitngTeam(int teamID, DevTeam newTeam)
        {
            DevTeam oldTeam = GetDevTeamById(teamID);
            if (oldTeam != null)
            {
                oldTeam.TeamID = newTeam.TeamID;
                oldTeam.TeamName = newTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateExisitingTeamDevelopers(int devId, int teamID, Developer newDev)
        {
            Developer oldDev = GetDevById(devId);


            DevTeam dTeam = GetDevTeamById(teamID);

            if (oldDev != null)
            {
                oldDev.DevID = newDev.DevID;
                oldDev.FirstName = newDev.FirstName;
                oldDev.LastName = newDev.LastName;
                oldDev.TeamAssignment = newDev.TeamAssignment;
                return true;
            }
            else
            {
                return false;
            }

        }
        // D
        public bool DisolveExisitingTeam(DevTeam existingDevTeam)
        {
            bool deleteResult = _devTeamDirectory.Remove(existingDevTeam);
            return deleteResult;

        }
        public bool RemoveExisitingTeamDevelopers(DevTeam dev)
        {
            bool deleteResult = _devTeamDirectory.Remove(dev);
            return deleteResult;
        }
    }
}
