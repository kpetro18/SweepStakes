using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesClass
    {
        // uses the Dictionary data structure
        //as an underlying structure.The Sweepstakes class will have the following methods with full
        //implementation(write the functionality) of each method:
        //- Sweepstakes(string name)
        //- void RegisterContestant(Contestant contestant)
        //- Contestant PickWinner()
        //- void PrintContestantInfo(Contestant contestant)

        //member variables
        public Dictionary<double, Contestant> contestants;

        public string name;
        //constructor
        public SweepStakesClass(string name)
        {
            contestants = new Dictionary<double, Contestant>();
            this.name = name;
        }

        //member methods

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner() 
        {
            Random rand = new Random();
            foreach (KeyValuePair<double, Contestant> person in contestants)
            {
                double winNumber = rand.Next(1, 1000);
                while (person.Key != winNumber)
                {
                    if (person.Key == winNumber)
                    {
                        return person.Value;
                    }
                    else
                    {
                        winNumber = rand.Next(1, 1000);
                    }
                }
            }
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1} \n" + "{2}", contestant.firstName, contestant.lastName, contestant.email);
        }
        public void CongratulateWinner() 
        {
            foreach (KeyValuePair<Double, Contestant> players in contestants)
            {
                if (players.Key != PickWinner().registrationNumber)
                {
                    Console.WriteLine("The Winner is: " + PickWinner().firstName + " " + PickWinner().lastName);
                }
                else
                {
                    Console.WriteLine("Congratulations " + PickWinner().firstName + PickWinner().lastName + " You win! \n" + "We have sent an email to: " + PickWinner().email + "\n Please contact us to claim your winnings");
                }
            }
        }
    }
}
