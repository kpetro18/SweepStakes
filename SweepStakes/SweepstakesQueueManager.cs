using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        //uses the Queue data structure as an underlying structure
        Queue<SweepStakesClass> queue = new Queue<SweepStakesClass>();
        public void InsertSweepstakes(SweepStakesClass sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public SweepStakesClass GetSweepstakes()
        {
            SweepStakesClass firstInLine = queue.Dequeue();
            return firstInLine;
        }
    }
}
