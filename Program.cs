using System;

namespace Assign_2
{
    public class bank_sys
    {
        int choice;
        protected int acc;
        protected string name;
        protected float balance;
        public virtual void header(){
            Console.WriteLine("\t\t\t Welcome to Bank module.");
        }
        public void getdata()
        {
            
            Console.WriteLine("____________________________________________Create an account____________________________________________");
            Console.WriteLine("\nEnter name");
            name = Console.ReadLine();
            acc = new Random().Next(10000, 99999);
            Console.WriteLine("Enter account type");
            Console.WriteLine("___________________Menu____________________");
            Console.WriteLine("1.Current account\n2.Saving account\n");
            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (choice == 1 || choice == 2)
            {
                Console.WriteLine(" \nDeposit initial amount.\nMinimum 1000 for current account. \n\tOR \nMinimum 5000 for saving account.");
                Console.WriteLine("Amount:");
                balance = float.Parse(Console.ReadLine());
            }
            if (choice == 1 && balance >= 1000 || choice == 2 && balance >= 5000)
            {
                Console.WriteLine("Account get created successfully");
                Console.WriteLine("\n______________________________________________________________________________________\n");
                display();
            }
            else
            {
                Console.WriteLine("\nInvalid choice.");
                Console.WriteLine("___________________________________________\n");
                getdata();
            }
        }
        public void deposit()
        {
            float ammount;
            Console.WriteLine("Enter amount to be deposited");
            ammount = float.Parse(Console.ReadLine());
            balance = balance + ammount;
            display(acc, balance);


        }
        public void withdraw()
        {
            float amt;
            Console.WriteLine("Enter withdrawl ammount");
            amt = float.Parse(Console.ReadLine());
            if ((choice == 1 && (balance - amt) < 1000) || (choice == 2 && (balance - amt) < 5000))
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amt;
                Console.WriteLine("Transaction successful");
                display(acc, balance);
            }

        }

        public virtual void display() 
        {
            Console.WriteLine("Name:  " + name);
            Console.WriteLine("Account number: " + acc);
            if (choice == 1)
                Console.WriteLine("Account type: Current Account");
            else
                Console.WriteLine("Account type: Saving Account");
            Console.WriteLine("Balance: " + balance);
        }
        public void display(int acc, float bal)
        {
            Console.WriteLine("Account number: " + acc);
            Console.WriteLine("Balance: " + balance);
        }
    }
}
