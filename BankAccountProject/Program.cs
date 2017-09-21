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
            Console.WriteLine();
            Console.WriteLine("Welcome to the bank.");
            Console.WriteLine("Let me look you up in our systems.");

            //need one general object, one checking object, one savings object
            

            //GeneralAccount mike = new GeneralAccount("Mike Mills", 0013245, "Lakewood", 1000000.00d);

            //mike.PrintInfo();
            //mike.AccountInfo();
            //Console.WriteLine();

            //CheckingAccount sally = new CheckingAccount("Sally Simpson", 0043210, "Duxbury", 500.00d);

            //sally.PrintInfo();
            //sally.AccountInfo();

            bool isBanking = true;

            while (isBanking == true)
            {
                Console.WriteLine("Please choose from the following options (choose a number):");
                Console.WriteLine("\t1.\tView your account information.");
                Console.WriteLine("\t2.\tView your total account balance.");
                Console.WriteLine("\t3.\tWithdraw funds");
                Console.WriteLine("\t4.\tDeposit funds");
                Console.WriteLine("\t5.\tEnd Banking");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                    GeneralAccount mikeGen = new GeneralAccount("Mike Mills", 0013245, "Lakewood", 1000000.00d);

                    if (choice == 1)
                    {
                        mikeGen.PrintInfo();
                        Console.WriteLine(  );
                    }

                    if (choice == 2)
                    {
                        mikeGen.AccountInfo();
                        Console.WriteLine();
                    }
                    
                    //mikeGen.AccountInfo();
                }

                if (choice == 3 || choice == 4)
                {
                    Console.WriteLine("Would you like to make that transaction in:");
                    Console.WriteLine("\t1.\tchecking or");
                        Console.WriteLine("\t2.\tsavings?");
                    int choiceB = int.Parse(Console.ReadLine());
                }

                if (choice == 5)
                {
                    Console.WriteLine("Thank you for banking with us today!");
                    Console.WriteLine("I hope we've EARNED your trust!");
                    Console.WriteLine("Press ENTER to leave the bank.");
                    Console.ReadLine();
                    isBanking = false;
                }

            }

            Environment.Exit(0);

            Console.WriteLine();

            //Console.WriteLine("Do you want to savings or checking?");
            //string choice = Console.ReadLine();

            //if (choice == "checking")
            //{
            //    CheckingAccount mikeC = new CheckingAccount("Mike Mills", 0013245, "Lakewood", 1000000.00);
            //}

            //mikeC.AccountInf0();
            

            Console.ReadLine();

            //while loop
            //isBanking = true
            //if "no" to another transaction:
            //isBanking = false, exit program

            //maybe the creating of instances has to be after picking checking or saving.




            //Console.WriteLine($"How can we help you today, {name}?);
        }
    }
}
