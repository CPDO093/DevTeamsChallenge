using DevTeams_Challenge_Repository.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Challenge_Repository
{
    public class DeveloperRepo
    {
         //This is our Repository class that will hold our directory (which will act as our database) and methods that will directly talk to our directory.

        protected readonly List<Developer> _devDirectory = new List<Developer>();



        // C
         public bool AddDeveloper(Developer developer)
         {

            if (developer != default)
            {
                int startingCount = _devDirectory.Count();
                _devDirectory.Add(developer);
                return _devDirectory.Count > startingCount ? true : false;

            }
            return false;

         }

        // R
        public Developer GetDevById(int id)
        {
                return _devDirectory.Where(d => d.DevID == id).SingleOrDefault();
        }

        public List<Developer> GetByTeamAssignment(TeamAssignment teamAssignment)
        {
            return _devDirectory.Where(d => d.TeamAssignment == teamAssignment).ToList();
        }

        public List<Developer> PluralSightAccess(bool onlineLearning)
        {
            return _devDirectory.Where(ol => ol.OnlineLearning == onlineLearning).ToList();
        }
        // U
        public bool UpdateExistingDevleloper(Developer newContent, int id)
        {
            Developer oldContent = GetDevById(id);
            if (oldContent != null)
            {
                oldContent.DevID = newContent.DevID;
                oldContent.FirstName = newContent.FirstName;
                oldContent.LastName = newContent.LastName;
                oldContent.TeamAssignment = newContent.TeamAssignment;
                oldContent.OnlineLearning = newContent.OnlineLearning;

                return true;

            }
            else
            {
                return false;
            }
        }
        // D
        public bool RemoveExisitingDeveloper(Developer existingDev)
        {
            bool deleteDeveloper = _devDirectory.Remove(existingDev);
            return deleteDeveloper;

        }
    }
    
}
