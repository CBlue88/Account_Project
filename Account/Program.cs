using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Declarations
            Savings_Account JohnsSavings = new Savings_Account();
            Checking_Account JohnsChecking = new Checking_Account();
            Reserve_Account JohnsReserves = new Reserve_Account();
            Account1 JohnInfo = new Account1();
            double currentAmount = 100.00;

            //StreamWriter Declarations
            StreamWriter Savingstransactions = new StreamWriter("savingstransacations.txt");
            StreamWriter Checkingtransactions = new StreamWriter("checkingstransacations.txt", true);
            StreamWriter Reservestransactions = new StreamWriter("reservestransacations.txt");


            //THIS IS WHERE THE CONSOLE PROMPTS STARTS
            Console.WriteLine("Welcome to banking with Wilco!");
            Console.WriteLine("Would would you like to do today?");
            Console.WriteLine("------------------------------------");
            List<string> menu = new List<string>();
            menu.Add("Deposit");
            menu.Add("Withdrawal");
            menu.Add("Current Balance");
            menu.Add("Client Info");
            menu.ForEach(Console.WriteLine);
            Console.WriteLine("Please type in your selection");
            Console.WriteLine("------------------------------------");
            string menuoption = Console.ReadLine(); //Let the nesting begin/ Deposits
            if (menuoption.Equals("Deposit", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Which Account would you like to make a deposit?");
                List<string> accountsmenu = new List<string>();
                accountsmenu.Add("Savings Account");
                accountsmenu.Add("Checking Account");
                accountsmenu.Add("Reserve Account");
                accountsmenu.ForEach(Console.WriteLine);
                Console.WriteLine("Please type your selection:");
                string accountmenuoption = Console.ReadLine();
                if (accountmenuoption.Equals("Savings Account", StringComparison.CurrentCultureIgnoreCase))

                {
                    Console.WriteLine("How much would you like to deposit?");
                    Console.WriteLine("Please type valid dollar amount");
                    double DepAmount = Convert.ToDouble(Console.ReadLine());
                    JohnsSavings.DepositCalculation(DepAmount, currentAmount);
                    JohnsSavings.DisplayEnding();
                }

                else if (accountmenuoption.Equals("Checking Account", StringComparison.CurrentCultureIgnoreCase))
                {
                   

                        //TEST THIS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        Console.WriteLine("How much would you like to deposit?");
                        Console.WriteLine("Please type valid dollar amount");
                        double DepAmount = Convert.ToDouble(Console.ReadLine());

                        JohnsChecking.DepositCalculation(DepAmount, currentAmount);
                        JohnsChecking.DisplayEnding();
                    
                    
                }
                else if (accountmenuoption.Equals("Reserve Account", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("How much would you like to deposit?");
                    Console.WriteLine("Please type valid dollar amount");
                    double DepAmount = Convert.ToDouble(Console.ReadLine());
                    JohnsReserves.DepositCalculation(DepAmount, currentAmount);
                    JohnsReserves.DisplayEnding();
                }
            }
            else if (menuoption.Equals("Withdrawal", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Which Account would you like to make a withdrawal?");
                List<string> accountsmenu = new List<string>();
                accountsmenu.Add("Savings Account");
                accountsmenu.Add("Checking Account");
                accountsmenu.Add("Reserve Account");
                accountsmenu.ForEach(Console.WriteLine);
                Console.WriteLine("Please type your selection:");
                string accountmenuoption = Console.ReadLine();

                if (accountmenuoption.Equals("Savings Account", StringComparison.CurrentCultureIgnoreCase))
                {

                    Console.WriteLine("How much would you like to withdraw?");
                    Console.WriteLine("Please type valid dollar amount");
                    double DepAmount = Convert.ToDouble(Console.ReadLine());
                    JohnsSavings.WithdrawalCaluclation(DepAmount, currentAmount);
                    JohnsSavings.DisplayEnding();
                }
                else if (accountmenuoption.Equals("Checking Account", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    Console.WriteLine("Please type valid dollar amount");
                    double DepAmount = Convert.ToDouble(Console.ReadLine());
                    JohnsChecking.WithdrawalCaluclation(DepAmount, currentAmount);
                    JohnsChecking.DisplayEnding();
                }
                else if (accountmenuoption.Equals("Reserve Account", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    Console.WriteLine("Please type valid dollar amount");
                    double DepAmount = Convert.ToDouble(Console.ReadLine());
                    JohnsReserves.WithdrawalCaluclation(DepAmount, currentAmount);
                    JohnsReserves.DisplayEnding();
                }

            }

            else if (menuoption.Equals("Current Balance", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Which Current Account Balance would you like to see?");
                List<string> accountsmenu = new List<string>();
                accountsmenu.Add("Savings Account");
                accountsmenu.Add("Checking Account");
                accountsmenu.Add("Reserve Account");
                accountsmenu.ForEach(Console.WriteLine);
                Console.WriteLine("Please type your selection:");
                string accountmenuoption = Console.ReadLine();

                if (accountmenuoption.Equals("Savings Account", StringComparison.CurrentCultureIgnoreCase))
                {
                    JohnsSavings.DisplayCurrentBalance();
                    JohnsReserves.DisplayEnding();
                }
                 else if(accountmenuoption.Equals("Checking Account",StringComparison.CurrentCultureIgnoreCase))
                {
                    JohnsChecking.DisplayCurrentBalance();
                    JohnsReserves.DisplayEnding();
                }
                 else if(accountmenuoption.Equals("Reserve Account", StringComparison.CurrentCultureIgnoreCase))
                {
                    JohnsReserves.DisplayCurrentBalance();
                    JohnsReserves.DisplayEnding();
                }
            }

            else if(menuoption.Equals("Client Info", StringComparison.CurrentCultureIgnoreCase))
            {
                JohnInfo.DisplayClientInfo();
                JohnInfo.DisplayEnding();
                
            }





        }
    }
}
