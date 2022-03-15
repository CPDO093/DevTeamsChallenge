using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Challenge_Repository
{
    public class DevelopersRepo
    {
        //This is our Repository class that will hold our directory (which will act as our database) and methods that will directly talk to our directory.

        protected readonly List<Developer> _devDirectory = new List<Developer>();

        // C

        // R
        public Devloper GetDevById(in int)
        {
            return _devDirectory.Where(d => d.DeveloperId == id).SingleOrDefualt();
        }

        public List<Developer> GetByTeamAssignment
        // U

        // D
    }
}