using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : GeneralAccount
    {
        //fields
        //these three are used only in Savings

        private double savingsBalance;
        private double interestRate = .03d;
        private double minimumBalance = 500;

        //properties

        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
        }

        public double MinimumBalance
        {
            get { return this.minimumBalance; }
        }

        //constructor

        public SavingsAccount()  //sets variables not in or different from GeneralAccount
        {   
            accountType = "savings";
            savingsBalance = accountBalance * .75; 
        }

        //methods

        public override void AccountInfo()  //prints info about savings account
        {
            Console.WriteLine();
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine($"The value of your {accountType} account only is {savingsBalance:C}.");
            Console.WriteLine();
        }

        public override void AccountDeposit() //overrides GeneralAccount method. does deposits
        {
            Console.WriteLine();
            Console.WriteLine($"Starting balance in savings is: {savingsBalance:C}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            savingsBalance += deposit;
            Console.WriteLine();
            Console.WriteLine($"Thank you for your deposit of {deposit:C}.");
            Console.WriteLine($"Your new balance in savings is: {savingsBalance:C}.");
            Console.WriteLine();
        }

        public override void AccountWithdrawal()  //overrides GeneralAccount method. does withdrawals
        {
            Console.WriteLine();
            Console.WriteLine($"Starting balance in savings is: {savingsBalance:C}.");
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            savingsBalance -= withdrawal;

            if (savingsBalance >= 500)  //if-else makes sure balance doesn't drop below minimum
            {
                Console.WriteLine(  );
                Console.WriteLine($"Here is your {withdrawal:C}.");
                Console.WriteLine($"Your new balance in checking is: {savingsBalance:C}.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"You must keep at least {minimumBalance:C} in your account.");
                savingsBalance += withdrawal;
                Console.WriteLine($"Your savings account balance is still {savingsBalance:C}.");
                Console.WriteLine();
            }
        }

        public override void InterestEarned()  //prints interest info to screen. overrides abstract method.
        {
            Console.WriteLine($"The interest rate in this account is {interestRate:P}.");
            Console.WriteLine($"You can expect to earn {interestRate * savingsBalance:C} this month.");
            Console.WriteLine();
        }
    }
}