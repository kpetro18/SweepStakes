using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesStackManager : ISweepstakesManager
    {
        //uses the Stack data structure as an underlying structure
        Stack<SweepStakesClass> stack = new Stack<SweepStakesClass>();
        public void InsertSweepstakes(SweepStakesClass sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public SweepStakesClass GetSweepstakes()
        {
            SweepStakesClass topOfStack = stack.Pop();
            return topOfStack;
        }
    }
}
