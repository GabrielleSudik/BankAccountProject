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

        protected double accountBalance = 10000.00d; //total amount of both checking and savings (divided in those classes)
        protected string accountType = ""; //left blank, assigned in other class

        
        //properties

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }  //doesn't need set because it won't change
        }


        //constructors

        public GeneralAccount() //default constructor. 
        {
            
        }


        //methods

        public virtual void AccountInfo()  //this will print total on deposit
        {
            Console.WriteLine();
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine();
        }

        public virtual void AccountDeposit() //not really needed; left in to practice virtual/override
        {

        }

        public virtual void AccountWithdrawal()
        {

        }

        abstract public void InterestEarned();
    }
}
