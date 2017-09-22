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
        private new string accountType = "checking";


        //properties

        public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        public String AccountType
        {
            get { return this.accountType; }
        }

        //constructor

        public CheckingAccount()
        {   //do i need all this? can it be different, like constructor creates the checkingBalance instead?
            //maybe if it accepts accountBalance then divides to creat checkingBalance?
            //this.name = name;
            //this.accountNumber = accountNumber;
            //this.city = city;
            //this.accountBalance = accountBalance;
            checkingBalance = accountBalance * .25; //at least this part works lol

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
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine($"The value of your {accountType} account only is {checkingBalance:C}.");
            Console.WriteLine();
        }

        public double AccountDeposit()
        {
            Console.WriteLine($"Starting balance in checking is: {checkingBalance:C}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            checkingBalance += deposit;
            Console.WriteLine($"Thank you for your deposit of {deposit:C}.");
            Console.WriteLine($"Your new balance in checking is: {checkingBalance:C}.");
            Console.WriteLine();

            return checkingBalance;

        }


        public override double AccountWithdrawal()
        {
            Console.WriteLine($"Starting balance in checking is: {checkingBalance:C}.");
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            checkingBalance -= withdrawal;

            if (checkingBalance >= 0)
            {
                Console.WriteLine($"Here is your {withdrawal:C}.");
                Console.WriteLine($"Your new balance in checking is: {checkingBalance:C}.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("You cannot withdraw more than what's in your account.");
                checkingBalance += withdrawal;
                Console.WriteLine($"Your checking account balance is still {checkingBalance:C}.");
                Console.WriteLine();
            }

            return checkingBalance;  //not needed i think
        }
    }
}
