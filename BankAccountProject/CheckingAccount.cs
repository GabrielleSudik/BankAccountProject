using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : GeneralAccount
    {
        //fields

        private double checkingBalance;


            //properties

            public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        //constructor

        public CheckingAccount()
        {   //do i need all this? can it be different, like constructor creates the checkingBalance instead?
            //maybe if it accepts accountBalance then divides to creat checkingBalance?
            //this.name = name;
            //this.accountNumber = accountNumber;
            //this.city = city;
            this.accountBalance = accountBalance;
            accountBalance = accountBalance * .25; //at least this part works lol

            //can you re-do that so it's just called accountBalance, but is .25 of total?
            //then same for checking but .75 of total?
            //might not matter EXCEPT it will mean less creating new variable names
        }

        //methods

        public void CheckingMenu()
        {
            //welcome to checking acct
            //show balance
            //ask deposit or wd?
            //ask amount
            //do relelvant math
            //show new balance
        }

        public override void AccountInfo()
        {

            Console.WriteLine($"The value of your checking account only is {checkingBalance}.");
        }

        public double AccountDeposit()
        {
            Console.WriteLine($"Starting balance in checking is: {checkingBalance}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            checkingBalance += deposit;
            Console.WriteLine($"Your new balance in checking is: {checkingBalance}.");

            return checkingBalance;

        }
        //public override double AccountWithdrawal()
        //{
        //    Console.WriteLine($"Starting balance in checking is: {accountBalance}.");
        //    Console.WriteLine("How much would you like to withdraw?");
        //    double deposit = Double.Parse(Console.ReadLine());
        //    accountBalance -= deposit;

        //    if (accountBalance >= 0)
        //    {
        //        Console.WriteLine($"Your new balance in checking is: {accountBalance}.");
        //        Console.WriteLine();
        //    }

        //    else
        //    {
        //        Console.WriteLine("You cannot withdraw more than what's in your account.");
        //        accountBalance += deposit;
        //        Console.WriteLine($"Your checking account balance is still {accountBalance}.");
        //    }

        //    return accountBalance;
        //}
    }
}
