using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class SweepstakeQueueManager : ISweepstakesManager
    {
        //private Sweepstake currentSweepstake;

        Dictionary<int, Sweepstake> sweepstakeList = new Dictionary<int, Sweepstake>();
        public SweepstakeQueueManager()
        {
           Sweepstake Sweepstake = GetSweepStake();
            Sweepstake.StartSweepstake();
           

        }


        void InsertSweepstake(Sweepstake sweepstake)
        {
            sweepstakeList.Add(0, sweepstake);//change to queue

        }

        Sweepstake GetSweepStake()//where does the sweepstake.start go??????????????????????????, and where does it return who needs it
        {
            Sweepstake sweepstake = sweepstakeList[0];//this instantiates the sweepstake
           
            return sweepstake;
        }

        
    }
}
