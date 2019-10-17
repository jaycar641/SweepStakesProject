using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class SweepstakeStackManager :ISweepstakesManager
    {
        Stack<Sweepstake> sweepstakeList = new Stack<Sweepstake>();
        public SweepstakeStackManager()
        {
            Sweepstake Sweepstake = GetSweepStake();
            Sweepstake.StartSweepstake();
        }      


        public void InsertSweepstake(Sweepstake sweepstake)
        {
            ///////////////can decide many sweepstakes to hold in queue
            sweepstakeList.Push(sweepstake);//change to queue

        }

        public Sweepstake GetSweepStake()//where does the sweepstake.start go??????????????????????????, and where does it return who needs it
        {
            Sweepstake sweepstake = sweepstakeList.Pop();//this instantiates the sweepstake

            return sweepstake;
        }

    }
}
