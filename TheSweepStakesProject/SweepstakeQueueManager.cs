using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class SweepstakeQueueManager : ISweepstakesManager
    {
        Dictionary<int, Sweepstake> sweepstakeList = new Dictionary<int, Sweepstake>();
        public SweepstakeQueueManager()
        {
        
        }


        void InsertSweepstake(Sweepstake sweepstake)
        {
            sweepstakeList.Add(0, sweepstake);
        }

        Sweepstake GetSweepStake(Sweepstake sweepstake)
        {
           sweepstake = sweepstakeList[0];
            
            return sweepstake;
        }
    }
}
