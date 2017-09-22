using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //fields

        protected string name = "Mike Mills"; 
        protected int accountNumber = 54321; //move to accounts? and create another field like years banked?
        protected string city = "Lakewood";

        //properties

        public string Name
        {
            get { return this.name; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string City
        {
            get { return this.city; }
        }

        //constructors

        public Client()
        {

        }

        //methods

        public void ClientInfo()
        {
            Console.WriteLine($"{name}, here is your basic bank info:");
            Console.WriteLine($"Your account number is {accountNumber}.");
            Console.WriteLine($"Your main bank branch is in {city}.");

            Console.WriteLine();
        }
        }
}
