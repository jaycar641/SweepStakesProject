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
        int numberOfContestants;
        public Sweepstake()//pass through contestant list, registration number, name
        {
            this.name = name;
            Random random = new Random();
           this.numberOfContestants = random.Next(0, 20);
            
        }

        public void StartSweepstake()
        {
            for (int i = 0; i < numberOfContestants; i++)
            {
                Contestant contestant = new Contestant();
                contestants.Add(contestant.GetRegistrationNumber, contestant);
                RegisterContestant(contestants[i]);

            }

            PickWinner();   //picks winner from the list
            PrintContestantInfo();      // prints the winner out;

        }

        public void RegisterContestant(Contestant contestant)
        {
            //adding contestants to a list

        }

        public Contestant PickWinner()
        {

            return;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
