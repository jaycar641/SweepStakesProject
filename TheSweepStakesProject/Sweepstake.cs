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
        public Sweepstake(string name)
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

            Contestant display = PickWinner();
            PrintContestantInfo(display);

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.GetRegistrationNumber, contestant);
            Console.WriteLine("Congratulations " + contestant.GetFirstName + " " + "you are now registered");
            Console.WriteLine("Your registration number is " + contestant.GetRegistrationNumber);

        }

        public Contestant PickWinner()
        {
            int contestantNumber = random.Next(0, numberOfContestants);
            int count = 0;
            Contestant winner = null;
            foreach (int key in contestants.Keys)
            {
                int regNumber = contestants[key].GetRegistrationNumber;
                if (count == contestantNumber)
                {
                    winner = contestants[key];
                    return winner;
                }
                count++;
             }
            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("And the winner is.........." + contestant.GetFirstName + " " + contestant.GetLastName);
            Console.WriteLine("Email " + contestant.GetEmail);
            Console.WriteLine("Registration Number " + contestant.GetRegistrationNumber);
            Console.ReadKey();
        }

    }
}
