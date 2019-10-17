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
        Random random = new Random();

        int numberOfContestants;
        public Sweepstake(string name)//pass through contestant list, registration number, name
        {
            this.name = name;
           this.numberOfContestants = random.Next(0, 20);
            
        }

        public void StartSweepstake()
        {
            for (int i = 0; i < numberOfContestants; i++)
            {
                Contestant contestant = new Contestant();
                RegisterContestant(contestant);

            }

               //picks winner from the list
            Contestant display = PickWinner();
            PrintContestantInfo(display);      // prints the winner out;

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.GetRegistrationNumber, contestant);
            Console.WriteLine("Congratulations " + contestant.GetFirstName + " " + "you are now registered");
            Console.WriteLine("Your registration number is " + contestant.GetRegistrationNumber);

        }

        public Contestant PickWinner()
        {
            int contestantNumber = random.Next(0, numberOfContestants);///uses contestant number to create a random number
            Contestant winner = new Contestant();
           
            for(int i = 0; i< numberOfContestants; i++)
            {
                if (i == contestantNumber)
                {
                    winner = contestants[i];///loop through dictionary
                }

            }

            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("And the winner is.........." + contestant.GetFirstName + " " + contestant.GetLastName);
            Console.WriteLine("Email " + contestant.GetEmail);
            Console.WriteLine("Registration Number " + contestant.GetRegistrationNumber);
        }

    }
}
