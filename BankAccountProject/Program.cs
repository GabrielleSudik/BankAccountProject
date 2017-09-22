using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of Gatlantiss.");
            Console.WriteLine("It is nice to see you again.");

            Client mikeClient = new Client();
            CheckingAccount mikeCh = new CheckingAccount();
            SavingsAccount mikeSv = new SavingsAccount();

            //need one general object, one checking object, one savings object

            bool isBanking = true;

            while (isBanking == true)
            {
                Console.WriteLine("Please choose from the following options (choose a number):");
                Console.WriteLine("\t1.\tView your account information.");
                Console.WriteLine("\t2.\tView your total account balance.");
                Console.WriteLine("\t3.\tWithdraw funds");
                Console.WriteLine("\t4.\tDeposit funds");
                Console.WriteLine("\t5.\tEnd Banking");
                int choice = int.Parse(Console.ReadLine());  //this line reads user input

                if (choice == 1)  //user checks client info
                {
                    mikeClient.ClientInfo();
                }

                if (choice == 2)  //user checks balances
                {
                    Console.WriteLine();
                    Console.WriteLine("Which account would you like to check?");
                    Console.WriteLine("\t1.\tchecking");
                    Console.WriteLine("\t2.\tsavings");
                    int choiceB = int.Parse(Console.ReadLine());
                    
                    if (choiceB == 1)
                    {
                        mikeCh.AccountInfo();
                        mikeCh.InterestEarned();
                    }
                    
                    if (choiceB == 2)
                    {
                        mikeSv.AccountInfo();
                        mikeSv.InterestEarned();
                    }
                }

                if (choice == 3)  //withdrawals
                {
                    Console.WriteLine();
                    Console.WriteLine("From which account would you like to withdraw funds?");
                    Console.WriteLine("\t1.\tchecking");
                    Console.WriteLine("\t2.\tsavings");
                    int choiceB = int.Parse(Console.ReadLine());

                    if (choiceB == 1)
                    {
                        mikeCh.AccountWithdrawal();  
                    }

                    if (choiceB == 2)
                    {
                        mikeSv.AccountWithdrawal();  
                    }
                }

                if (choice == 4)  //deposits
                {
                    Console.WriteLine();
                    Console.WriteLine("To which account would you like to deposit funds?");
                    Console.WriteLine("\t1.\tchecking");
                    Console.WriteLine("\t2.\tsavings");
                    int choiceB = int.Parse(Console.ReadLine());

                    if (choiceB == 1)
                    {
                        mikeCh.AccountDeposit();  
                    }

                    if (choiceB == 2)
                    {
                        mikeSv.AccountDeposit();  
                    }
                }

                if (choice == 5)  //quit program
                {
                    Console.WriteLine("Thank you for banking with us today!");
                    Console.WriteLine("I hope we've EARNED your trust!");
                    Console.WriteLine("Press ENTER to leave the bank.");
                    Console.ReadLine();
                    isBanking = false;  //ends loop
                }
            }

            Environment.Exit(0);  //exits program after loop ends
        }
    }
}
