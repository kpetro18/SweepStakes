using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        //member variables (has a)
        public string firstName;
        public string lastName;
        public string email;
        public double registrationNumber;

        //constructor (spawner)
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            email = UserInterface.GetEmail();
            registrationNumber = UserInterface.AssignRegistrationNumber();
        }

        //member methods (can do)


    }
}
