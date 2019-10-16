using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Marketing
    {
        private Sweepstake sweepstake = new Sweepstake();


        public Marketing()
        {
            this.sweepstake = new Sweepstake();

        }

        public void ChooseManager()
        {
            Console.WriteLine("Choose your manager: Queue, or Stack");
            string managerChoice = Console.ReadLine();

            switch(managerChoice) //could potential return a dictionary with manager and manager type
            {
                case "Queue":
                    new SweepstakeQueueManager();
                    break;
                case "Stack":
                    new SweepstakeStackManager();
                    break;
                
            }

        }

       public Sweepstake Sweepstake
        {
            get
            {
                return sweepstake;
            }

            set 
           {
                value = sweepstake;
            }
        }









    }
}
