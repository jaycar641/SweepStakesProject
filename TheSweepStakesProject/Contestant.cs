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
            TheFirstName();
            TheLastName();
            TheEmail();
            TheRegistrationNumber();
        }


        
        public string FirstName 
       {
            get 
            {
                return firstName;
            }

            set 
            {
               firstName = value;
            }
        
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
               lastName = value;
            }

        }

        public string Email
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }

        }

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;

            }
        }
        public void TheFirstName()
        {
            Console.WriteLine("Enter Your First Name");
            this.FirstName = Console.ReadLine();
        }

        public void TheLastName()
        {
            Console.WriteLine("Enter Your Last Name");
            this.LastName = Console.ReadLine();
        }

        public void TheEmail()
        {
            Console.WriteLine("Enter Your Email Address");
            this.Email = Console.ReadLine();
        }

        public void TheRegistrationNumber()
        {
Random random = new Random();
                this.RegistrationNumber = random.Next(0, 1000);
       }




    }
}
