using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Marketing
    {
        private Sweepstake sweepstake;

        ////////Constructors
        public Marketing()
        {
            this.sweepstake = new Sweepstake("Sweepstake");
            ChooseManager();
        }
            
           ////// Properties
        public Sweepstake Sweepstake
        {
            get
            {
                return this.sweepstake;
            }

            set
            {
                value = this.sweepstake;
            }
        }


        /////////////Function
        public void ChooseManager()
        {
            Console.WriteLine("Choose your manager: Queue, or Stack");
            string managerChoice = Console.ReadLine();

            switch(managerChoice) //could potential return a dictionary with manager and manager type
            {
                case "Queue":
                    CreateManager(new SweepstakeQueueManager());
                    break;
                case "Stack":
                    CreateManager(new SweepstakeStackManager());
                    break;
                
            }

        }

        public void CreateManager(ISweepstakesManager manager)
        {
           
           manager.InsertSweepstake(Sweepstake);
            manager.GetSweepStake();

        }
       








    }
}
