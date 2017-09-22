using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : GeneralAccount
    {

        //idea: savings will start at 75% of total balance, checking at 25%

        //fields

        private double savingsBalance;
        private new string accountType = "savings";


        //properties

        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }  //I THINK this will always print "savings" in accountType here
        }

        //constructor

        public SavingsAccount() 
        {   //do i need all this? can it be different, like constructor creates the checkingBalance instead?
            //maybe if it accepts accountBalance then divides to creat checkingBalance?
            //this.name = name;
            //this.accountNumber = accountNumber;
            //this.city = city;
            //this.accountBalance = accountBalance;
            savingsBalance = accountBalance * .75; //at least this part works lol
        }

        //methods

        public void SavingsMenu()
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
            //Console.WriteLine($"You account number is {accountNumber}.");
            Console.WriteLine($"The value of ALL of your deposits is: {accountBalance:C}.");
            Console.WriteLine($"The value of your {accountType} account only is {savingsBalance:C}.");
            Console.WriteLine();
        }

        public double AccountDeposit()
        {
            Console.WriteLine($"Starting balance in savings is: {savingsBalance:C}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            savingsBalance += deposit;
            Console.WriteLine($"Thank you for your deposit of {deposit:C}.");
            Console.WriteLine($"Your new balance in savings is: {savingsBalance:C}.");
            Console.WriteLine();

            return savingsBalance;

        }

        public override double AccountWithdrawal()
        {
            int minimumBalance = 500;

            Console.WriteLine($"Starting balance in savings is: {savingsBalance:C}.");
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            savingsBalance -= withdrawal;

            if (savingsBalance >= 500)
            {
                Console.WriteLine($"Here is your {withdrawal:C}.");
                Console.WriteLine($"Your new balance in checking is: {savingsBalance:C}.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine($"You must least at least {minimumBalance:C} in your account.");
                savingsBalance += withdrawal;
                Console.WriteLine($"Your savings account balance is still {savingsBalance:C}.");
                Console.WriteLine();
            }

            return savingsBalance;  //not needed i think
        }
    }
}
