using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class GeneralAccount
    {
        //fields

        protected string name; //assign name here since just one client?
        protected int accountNumber; //ditto
        protected string city;
        protected double accountBalance; //can this be the total of S and C?



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

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }


        //constructors

        public GeneralAccount() //default constructor. not sure if leave empty or set info?
        {
            name = "Mike Mills";
        }

        public GeneralAccount(string name, int accountNumber, string city, double accountBalance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.city = city;
            this.accountBalance = accountBalance;
        }


        //methods

        public void PrintInfo()
        {
            Console.WriteLine("Here's your bank info: //coming soon");
            Console.WriteLine(this.name);
            Console.WriteLine(accountNumber);
            Console.WriteLine(city);

        }

        public virtual void AccountInfo()
        {
            //make this do something that will be overriden by savings and checking
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance}."); //look up how to print $$
        }

        //abstract public double AccountDeposit(); //should this be abstract? can it be? I NEED one
        //now it is... why am i getting red squigglies? :(
        //i temporarily fixed this problem by coding it out here, and removing "override" in derived method
        //but i don't like that :(



    }
}
