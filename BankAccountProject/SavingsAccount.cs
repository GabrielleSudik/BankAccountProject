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


        //properties

        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        //constructor

        public SavingsAccount() 
        {   //do i need all this? can it be different, like constructor creates the checkingBalance instead?
            //maybe if it accepts accountBalance then divides to creat checkingBalance?
            //this.name = name;
            //this.accountNumber = accountNumber;
            //this.city = city;
            this.accountBalance = accountBalance;
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
            Console.WriteLine($"The value of your savings account only is {savingsBalance}.");
        }

        public double AccountDeposit()
        {
            Console.WriteLine($"Starting balance in savings is: {savingsBalance}.");
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            deposit += savingsBalance;
            Console.WriteLine($"Your new balance in checking is: {savingsBalance}.");

            return savingsBalance;

        }
    }
}
