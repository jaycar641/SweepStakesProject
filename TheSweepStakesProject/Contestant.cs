using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Contestant: IUserInput
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        public Contestant()
        {
            FirstName();
            LastName();
            Email();
            RegistrationNumber();
            //run user interface to ask for information
        }
       public void FirstName()
        {
            Console.WriteLine("Enter Your First Name");
            firstName = Console.ReadLine();
        }

        public void LastName()
        {
            Console.WriteLine("Enter Your Second Name");
            lastName = Console.ReadLine();
        }

        public void Email()
        {
            Console.WriteLine("Enter Your Second Name");
            emailAddress = Console.ReadLine();
        }

        public void RegistrationNumber()
        {
            //get registration #
            registrationNumber = 5;
        }




    }
}
