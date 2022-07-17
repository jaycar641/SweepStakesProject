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
     

        public void InsertSweepstake(Sweepstake sweepstake)
        {
            sweepstakeList.Push(sweepstake);

            
        }

        public Sweepstake GetSweepStake(string name)
        {
            Sweepstake replaced = new Sweepstake (name);
            replaced = sweepstakeList.Pop();
           replaced.StartSweepstake();

            return replaced;
        }

    }
}
