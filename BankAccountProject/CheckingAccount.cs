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
        {   
            checkingBalance = accountBalance * .25;
            accountType = "checking";
        }

        //methods

        public override void AccountInfo() //prints account info. overrides virtual method in GeneralAccount
        {
            Console.WriteLine();
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine($"The value of your {accountType} account only is {checkingBalance:C}.");
            Console.WriteLine();
        }

        public override void AccountDeposit() //handles deposits. overrides virtual method in GeneralAccount
        {
            Console.WriteLine();
            Console.WriteLine($"Starting balance in checking is: {checkingBalance:C}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            checkingBalance += deposit;
            Console.WriteLine($"Thank you for your deposit of {deposit:C}.");
            Console.WriteLine($"Your new balance in checking is: {checkingBalance:C}.");
            Console.WriteLine();
        }

        public override void AccountWithdrawal() //handles withdrawals. overrides virtual method in GeneralAccount
        {
            Console.WriteLine();
            Console.WriteLine($"Starting balance in checking is: {checkingBalance:C}.");
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            checkingBalance -= withdrawal;

            if (checkingBalance >= 0)  //if-else makes sure withdrawal doesn't go below $0.
            {
                Console.WriteLine();
                Console.WriteLine($"Here is your {withdrawal:C}.");
                Console.WriteLine($"Your new balance in checking is: {checkingBalance:C}.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("You cannot withdraw more than what's in your account.");
                checkingBalance += withdrawal;
                Console.WriteLine($"Your checking account balance is still {checkingBalance:C}.");
                Console.WriteLine();
            }
        }

        public override void InterestEarned()  //prints interest info. overrides abstract method.
        {
            Console.WriteLine("This account does not earn interest.");
            Console.WriteLine();
        }
    }
}
