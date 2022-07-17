using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class SweepstakeQueueManager : ISweepstakesManager
    {   
        Queue<Sweepstake> sweepstakeList = new Queue<Sweepstake>();

        public void InsertSweepstake(Sweepstake sweepstake)
        {
            
          sweepstakeList.Enqueue(sweepstake);


        }

        public Sweepstake GetSweepStake(string name)
        {

            Sweepstake sweepstake = sweepstakeList.Dequeue();
                       sweepstake.StartSweepstake();
            return sweepstake;
        }

        
    }
}
