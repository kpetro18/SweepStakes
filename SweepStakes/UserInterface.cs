using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class UserInterface
    {
        //for any information the application would
        //need to get from the user.One example would be the functionality to assign a Contestant object a first
        //name, last name, email address, and registration number.

        double lastRegisteredNumber = 1;

        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static double AssignRegistrationNumber()
        {
            Random number = new Random();
            double registrationNumber = number.Next(1, 1000000);
            Console.WriteLine("Your registration number is: {0}", registrationNumber);
            return registrationNumber;
        }

    }
}
