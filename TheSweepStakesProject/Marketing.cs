using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Marketing:ISweepstakesManager
    {
        Dictionary<string, string> managers = new Dictionary<string, string>(); //creating a dictionary of all the managers and their lists
        public Marketing()
        {
            managers.Add("Bob", "queue");
            managers.Add("John", "stack");
            managers.Add("Sam", "queue");
            managers.Add("Megan", "stack");
            managers.Add("Tracy", "queue");

        }


        public string ChooseManager()
        {
            Console.WriteLine("Choose your manager: Bob, John, Sam, Megan, Tracy");
            string managerChoice = Console.ReadLine();

            switch(managerChoice) //could potential return a dictionary with manager and manager type
            {
                case "Bob":
                    CreateManager("Bob");
                    break;
                case "John":
                    CreateManager("John");
                    break;
                case "Sam":
                    CreateManager("Sam");
                    break;
                case "Megan":
                    CreateManager("Megan");
                    break;
                case "Tracy":
                    CreateManager("Tracy");
                    break;


            }
            return managerChoice;

        }


        public ISweepstakesManager CreateManager(string manager)
        {
            ISweepstakesManager man = new SweepstakeStackManager(); //default

            switch(manager)
            {
                case "Bob":
                    ISweepstakesManager Bob = new SweepstakeQueueManager();
                    return Bob;
                    break;
                case "John":
                    ISweepstakesManager John = new SweepstakeStackManager();
                    return John;
                    break;
                case "Tracy":
                    ISweepstakesManager Tracy = new SweepstakeQueueManager();
                    return Tracy;
                    break;
                case "Sam":
                    ISweepstakesManager Sam = new SweepstakeQueueManager();
                    return Sam;
                    break;
                case "Megan":
                    ISweepstakesManager Megan = new SweepstakeStackManager();
                    return Megan;
                    break;
                default:
                    {
                        Console.WriteLine("Please Choose a manager");
                        break;
                    }

            }
            return man;



        }



    }
}
