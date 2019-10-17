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
        Queue<Sweepstake> sweepstakeList = new Queue<Sweepstake>();
        public SweepstakeQueueManager()
        {
           Sweepstake Sweepstake = GetSweepStake();
            Sweepstake.StartSweepstake();
           
        }


        public void InsertSweepstake(Sweepstake sweepstake)
        {
            ///////////////can decide many sweepstakes to hold in queue
            sweepstakeList.Enqueue(sweepstake);//change to queue

        }

        public Sweepstake GetSweepStake()//where does the sweepstake.start go??????????????????????????, and where does it return who needs it
        {
            Sweepstake sweepstake = sweepstakeList.Dequeue();//this instantiates the sweepstake
           
            return sweepstake;
        }

        
    }
}
