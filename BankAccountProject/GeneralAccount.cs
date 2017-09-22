using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class GeneralAccount
    {
        //fields

        protected double accountBalance = 100000.00d; //can this be the total of S and C?
        protected string accountType = "";

        
        //properties


        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }


        //constructors

        public GeneralAccount() //default constructor. not sure if leave empty or set info, like acct type?
        {
            //this.accountType = accountType;
        }


        //methods


        public virtual void AccountInfo()
        {
            //make this do something that will be overriden by savings and checking
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine();
        }

        //abstract public double AccountDeposit(); //should this be abstract? can it be? I NEED one
        //now it is... why am i getting red squigglies? :(
        //i temporarily fixed this problem by coding it out here, and removing "override" in derived method
        //but i don't like that :(

        public virtual double AccountDeposit() //maybe need parameter here for account type? or somewhere. 
            //constructors in Ch or Sv maybe?
            //maybe make this the abstract class, since Ch and Sv each use their own balance?
        {
            Console.WriteLine($"Starting balance in checking is: {accountBalance:C}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            accountBalance += deposit;
            Console.WriteLine($"Your new balance in checking is: {accountBalance:C}.");
            Console.WriteLine();

            return AccountBalance;

        }

        public virtual double AccountWithdrawal()
        {
            Console.WriteLine($"Starting balance in checking is: {accountBalance}.");
            Console.WriteLine("How much would you like to withdraw?");
            double deposit = Double.Parse(Console.ReadLine());
            accountBalance -= deposit;
            Console.WriteLine($"Your new balance in checking is: {accountBalance}.");
            Console.WriteLine();

            return accountBalance; //remove and switch double to void

        }
    }
}
