using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Sweepstake
    {
        public string name;
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
       
       private bool complete = false;

       public int numberOfContestants;
        
        public Sweepstake(string name)
        {
            this.name = name;
             Random random = new Random();
           this.numberOfContestants = random.Next(0, 20);
            
        }

        public bool Complete
        {
            get
            {
                return complete;
            }

            set
            {
                complete = value;

            }
        }


        
        
        public void StartSweepstake()
        {
             Console.WriteLine("There are " + numberOfContestants + " number of Contestants");
            
            for (int i = 0; i < numberOfContestants; i++)
            {
                int regNumber = i + 1;
                Contestant contestant = new Contestant();
                Console.WriteLine("Contestant #" + regNumber + " is " + contestant.FirstName + " " + contestant.LastName);
                RegisterContestant(contestant);

            }

            Contestant display = PickWinner();
            PrintContestantInfo(display);

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
            Console.WriteLine("Congratulations " + contestant.FirstName + " " + "you are now registered");
            Console.WriteLine("Your registration number is " + contestant.RegistrationNumber);

        }

        public Contestant PickWinner()
        {
            Random random = new Random ();
            Contestant contestant = new Contestant();   
            int contestantNumber = random.Next(0, numberOfContestants);
            int count = 0;
            contestant = null;
            foreach (int key in contestants.Keys)
            {
                int regNumber = contestants[key].RegistrationNumber;
                if (count == contestantNumber)
                {
                    contestant = contestants[key];
                    return contestant;
                }
                count++;
             }
            return contestant;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("And the winner is.........." + contestant.FirstName + " " + contestant.LastName);
            Console.WriteLine("Email " + contestant.Email);
            Console.WriteLine("Registration Number " + contestant.RegistrationNumber);
            Console.ReadKey();
        }

    }
}
