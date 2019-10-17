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
            Sweepstake Sweepstake = GetSweepStake();

            sweepstake.StartSweepstake();

        }

        public Sweepstake GetSweepStake()
        {

            Sweepstake sweepstake = sweepstakeList.Dequeue();

            return sweepstake;
        }

        
    }
}
