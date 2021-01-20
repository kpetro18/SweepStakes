using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        //member variables (has a)
        string firstName;
        string lastName;
        string email;
        double registrationNumber;

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
