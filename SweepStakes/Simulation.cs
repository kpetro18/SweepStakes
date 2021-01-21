using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm newMarketingFirm = new MarketingFirm(ManagerStyleChoice());
            newMarketingFirm.CreateSweepstakes();
        }
        public ISweepstakesManager ManagerStyleChoice()
        {
            Console.WriteLine("Please select which type of manager style you'd like to use: \n type 1 for Stack \n type 2 for Queue");
            string userInput = Console.ReadLine();
            int userInputConverted = Convert.ToInt16(userInput);
            if (userInputConverted == 1)
            {
                MarketingFirm stackManager = new MarketingFirm(new SweepStakesStackManager());
                SweepStakesStackManager stackMan = new SweepStakesStackManager();
                return stackMan;
            }
            else if (userInputConverted == 2)
            {
                MarketingFirm queueManager = new MarketingFirm(new SweepstakesQueueManager());
                SweepstakesQueueManager queueMan = new SweepstakesQueueManager();
                return queueMan;
            }
            else
            {
                return ManagerStyleChoice();
            }
        }
    }
}
