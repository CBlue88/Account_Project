using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account1
    {
        //FIELDS
        //Make private so that outside info can't change values except by those used in the methods for constructors

        private string name;
        private int accountnumber;
        private string accounttype;
        private double currentAmount = 100;
        private double DepAmount;
        private double AddedDepAmount;
        private double WithAmount;
        private double SubWithAmount;
        //Display Method will static, no need to do stuff.
        //Only the class should have methods on how to interact with its data, Call the results to the main.

        
        //Properties

        public string Accounttype
        {
            get { return this.Accounttype; }
            set { this.Accounttype = value; }
        }

        public double CurrentAmount
        {
            get { return this.currentAmount; }
            set { this.currentAmount = value; }
        }

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int AccountNumber
        {
            get { return this.AccountNumber; }
            set { this.AccountNumber = value; }
        }
        //Constructors
        

        public Account1()
        {
            this.name = "John";
            this.accountnumber = 12345678;
            //hard coded as there this assignment is only for one person, the values do not need to be set by the user. 
        }

        public Account1(string name, int accountnumber, string accounttype)
        {
            this.name ="John";
            this.accountnumber= 12345678;
            this.accounttype=accounttype;
        }

        public Account1(string name, int accountnumber, string accounttype, double amount)
        {
            this.name ="John";
            this.accountnumber = 12345678;
            this.accounttype = accounttype;//the "this.accounttype = accounttype" is assigning the value from the constructor IN that instance variable in the Class Field: Account Type 
            this.currentAmount = 100;
        }

        //METHODS START HERE
        
        public double DepositCalculation(double DepAmount, double currentAmount)
        {
           
                AddedDepAmount = DepAmount + currentAmount;
                Console.WriteLine("+" + AddedDepAmount + " " + "is your new account total.");
                DateTime time = DateTime.Now;
                Console.WriteLine("Transaction happened at:" + " " + time);
                return AddedDepAmount;
            
        }

        public double WithdrawalCaluclation(double withamount, double currentAmount)
        {
            SubWithAmount = currentAmount - withamount;
            
            if(withamount < 0 )
            {
                Console.WriteLine("You can't withdraw less than zero");
            }
            else
            {
                 Console.WriteLine("-" + SubWithAmount + " " + "is your new account total.");
            }
           
            DateTime time = DateTime.Now;
            Console.WriteLine("Transaction happened at:" + " " + time);
             return SubWithAmount; 
            
        }

        public void DisplayCurrentBalance()
        {
            Console.WriteLine(currentAmount);
        }
        
        //This method has the time stamp requirement of the assignment
        public void DisplayClientInfo()
        {
            
            Console.WriteLine(name);
            Console.WriteLine(accountnumber);
            

        }

        public void DisplayEnding()
        {
            Console.WriteLine("Thank you for banking with Wilco");
        }


    }
}
