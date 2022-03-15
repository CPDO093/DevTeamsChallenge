using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Challenge_Repository
{
    public enum TeamAssignment { FrontEnd, BackEnd, Testing}
    public class Developer
    {
        //This is our POCO class. It will define our properties and constructors of our Developer objects.
        //Developer objects should have the following properties
            //ID (int)
            //FirstName
            //LastName
            //a bool that shows whether they have access to the online learning tool Pluralsight.
            //TeamAssignment - use the enum declared above this class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DevID { get; set; }
        public TeamAssignment TeamAssignment { get; set; }
        public bool OnlineLearning { get; set; }

        public Developer() { }
        public Developer(string firstName)
        {
            FirstName = firstName;

        }
        public Developer(string firstName, string lastName)
            : this(firstName)
        {
            LastName = lastName;

        }
        public Developer(string firstName, string lastName, int devId)
            : this(firstName,lastName)
        {
            DevID = devId;
        }
        public Developer(string firstName, string lastName, int devId, TeamAssignment teamAssignment)
            : this(firstName, lastName,devId)
        {
            TeamAssignment = teamAssignment;
        }
        public Developer(string firstName, string lastName, int devId, TeamAssignment teamAssignment, bool onlineLearning)
            : this(firstName, lastName, devId, teamAssignment)
        {
            OnlineLearning = onlineLearning;
        }











    }
}
