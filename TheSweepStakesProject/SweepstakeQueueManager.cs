using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class SweepstakeQueueManager : ISweepstakesManager
    {
        private string name;

        public SweepstakeQueueManager(List<Sweepstake> list, string name)
        {
            this.name = name;
        }

        void InsertSweepstake(Sweepstake sweepstakes)
        {

        }

        Sweepstake GetSweepStake()
        {


        }
    }
}
