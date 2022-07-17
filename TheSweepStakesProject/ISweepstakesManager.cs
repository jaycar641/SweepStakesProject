using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    interface ISweepstakesManager
    {
       void InsertSweepstake(Sweepstake sweepstakes);

       Sweepstake GetSweepStake(string name);

    }
}
