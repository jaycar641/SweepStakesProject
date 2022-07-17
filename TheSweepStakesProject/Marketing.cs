
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

    
        public Marketing()
        {
            this.sweepstake = new Sweepstake("name"); 
            ChooseManager();
        }
            
           
        public Sweepstake sweepValue
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


        public void ChooseManager()
        {
            Console.WriteLine("Choose your manager: Queue, or Stack");
            string managerChoice = Console.ReadLine();

            switch(managerChoice) 
            {
                case "Queue":
                   SweepstakeQueueManager queueManager = new SweepstakeQueueManager();
                    CreateManager(queueManager);
                    break;
                case "Stack":
                    SweepstakeStackManager stackManager = new SweepstakeStackManager();
                    CreateManager(stackManager);
                    break;
                default:
                    Console.WriteLine("Please try again");
                    ChooseManager();
                    break;
                
            }

        }

        public void CreateManager(ISweepstakesManager manager)
        {
           manager.InsertSweepstake(this.sweepstake);
            
           this.sweepstake = manager.GetSweepStake ();    
            this.sweepstake.Complete= true;
            manager.InsertSweepstake(this.sweepstake);
            

        }
       








    }
}
