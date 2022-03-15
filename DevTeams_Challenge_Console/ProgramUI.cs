using DevTeams_Challenge_Repository;
using DevTeams_Challenge_Repository.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Challenge_Console
{
    public class ProgramUI
    {
        //This class will be how we interact with our user through the console.
        //When we need to access our data, we will call methods from our Repo class.

        private DevTeamsRepo _devTeamRepo = new DevTeamsRepo();
        

        public void Run()
        {
            //SeedContent();
            Menu();
        }

        private void Menu()
        {
            //Start with the main menu here
            //Menu options we'll need and the methods you'll need to make
            
            bool runMenu = true;
            while (runMenu)
            {
                Console.Clear();

              Console.WriteLine("1. Create New Developer \n" +
              "2. Create New DevTeam\n"+
              "3. Add A Dev To A Team \n"+
              "4. Display All Developers\n"+
              "5. Display Developers By Team\n"+
              "6. Display Developer By Id\n"+
              "7. Update Existing Developer\n"+
              "8. Delete Existing Developer\n"+
              "9. Delete Existing DevTeam\n"+
              "10. PluralSightAccess\n" +
              "11. exit");

                switch (Console.ReadLine())
                {

                    case "1":
                        CreateNewDeveloper();
                        break;

                    case "2":
                        CreateNewDevTeams();
                        break;

                    case "3":
                        AddDevelopertoDevTeam();
                        break;

                    case "4":
                        DisplayAllDevelopers();
                        break;

                    case "5":
                        DisplayDevelopersByTeam();
                        break;

                    case "6":
                        DisplayDeveloperById();
                        break;

                    case "7":
                        UpdateExistingDeveloper();
                        break;

                    case "8":
                        DeleteExistingDeveloper();
                        break;

                    case "9":
                        DeleteExisitingDevTeam();
                        break;
                    case "10":
                        PluralSightAccess();
                        break;
                    case "11":
                    case "exit":
                    case "e":
                        runMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 11 to continue.");
                        Console.ReadKey();
                        break;
                }
            }
            

        }

        //Create/Add
        private void CreateNewDeveloper()
        {
            Console.Clear();
            Developer newDev = new Developer();

            //FirstNAme
            Console.WriteLine("Enter First Name: ");
            newDev.FirstName = Console.ReadLine();
            //Last Name
            Console.WriteLine("Enter Last Name: ");
            newDev.LastName = Console.ReadLine();
            //ID
            Console.WriteLine("Enter Developer ID: ");
            newDev.DevID = int.Parse(Console.ReadLine());
            //Team
            Console.WriteLine("Choose Assigned Team\n "+
                "1. FrontEnd\n"+
                "2. BackEnd\n"+
                "3. Testing");
            string teamInPut = Console.ReadLine();
            int teamAssigned = int.Parse(teamInPut);
            newDev.TeamAssignment = (TeamAssignment)teamAssigned;

            //Online Learning
            Console.WriteLine("PluralSight access: ");
            string learnInPut = Console.ReadLine();

            if (_devTeamRepo.AddDeveloper(newDev))
            {
                Console.WriteLine("New Developer Added");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Failure to add, press any key to continue.");
                Console.ReadKey();
            }
        }
        private void CreateNewDevTeams()
        {
            Console.Clear();

            DevTeam devT = new DevTeam(); 
            //Team Name
            Console.WriteLine("Enter New Team Name: ");
            devT.TeamName = Console.ReadLine();
            //Team ID
            Console.WriteLine("Enter New Team ID");
            devT.TeamID = int.Parse(Console.ReadLine());

            if (_devTeamRepo.AddNewDevTeam(devT))
            {
                Console.WriteLine("New Team Added!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Failure To Add New Team. Press Any Key To Continue.");
                Console.ReadKey();
            }
        }


        //Read
        private void DisplayAllDevelopers()
        {

        }
        private void DisplayDevelopersByTeam()
        {

        }
        private void DisplayDeveloperById()
        {

        }
        private void PluralSightAccess()
        {

        }

        //Update
        private void UpdateExistingDeveloper()
        {

        }
        private void AddDevelopertoDevTeam()
        {
            // Dev Assignment
            //FirstNAme
            //Last Name
            //ID
            //Team
            
        }

        //Delete
        private void DeleteExistingDeveloper()
        {

        }
        private void DeleteExisitingDevTeam()
        {

        }



        // Helpermethods you should write
        // A method to print a developer's first and last name, useful in display all
        // private void DisplayDevBasicInfo(Developer dev) {}

        // A method to print a developers full information, useful when showing one developer
        // private void DisplayDevFullInfo(Developer dev) {}


        //private void SeedContent(){}
    }
}
