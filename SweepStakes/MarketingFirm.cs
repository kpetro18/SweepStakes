using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public ISweepstakesManager Manager { get => _manager; set => _manager = value; }

        // MarketingFirm uses Dependency Injection because you can use either Stack or Queue due to both Manager classes inheritting from ISweepStakesManager

        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }

        public void CreateSweepstakes()
        {
            Console.WriteLine("Please enter the name of your Sweepstakes: ");
            string userInput = Console.ReadLine();
            SweepStakesClass sweepstakes = new SweepStakesClass(userInput);
        }
    }
}
