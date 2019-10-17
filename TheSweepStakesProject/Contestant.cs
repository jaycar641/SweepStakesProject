using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSweepStakesProject
{
    class Contestant : IUserInput
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


        //Properties
        public string GetFirstName 
       {
            get 
            {
                return this.firstName;
            }

            set 
            {
                value = this.firstName;
            }
        
        }

        public string GetLastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                value = this.lastName;
            }

        }

        public string GetEmail
        {
            get
            {
                return this.emailAddress;
            }

            set
            {
                value = this.emailAddress;
            }

        }

        public int GetRegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                value = registrationNumber;

            }
        }
        public void FirstName()
        {
            Console.WriteLine("Enter Your First Name");
            GetFirstName = Console.ReadLine();
        }

        public void LastName()
        {
            Console.WriteLine("Enter Your Second Name");
            GetLastName = Console.ReadLine();
        }

        public void Email()
        {
            Console.WriteLine("Enter Your Email Address");
            GetEmail = Console.ReadLine();
        }

        public void RegistrationNumber()
        {
            Random random = new Random();
            GetRegistrationNumber = random.Next(1000000, 9999999);
       }




    }
}
