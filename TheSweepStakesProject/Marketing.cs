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


        public void ChooseManager()
        {
            Console.WriteLine("Choose your manager: Queue, or Stack");
            string managerChoice = Console.ReadLine();

            switch(managerChoice) 
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
           

        }
       








    }
}
