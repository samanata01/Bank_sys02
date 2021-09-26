using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2
{
    public class loan : bank_sys
    {
        int salary, loan_amt,tenure,emi;
        public void loan_sys ()
        {
            
            Console.WriteLine("Enter your salary.");
            salary = Convert.ToInt32(Console.ReadLine());
            loan_amt = salary * 60 / 100;
            Console.WriteLine("Maximum loan amount you will get is:" + loan_amt);
            Console.WriteLine("(Loan amount is typically 60% of salary)");
            Console.WriteLine("Enter tenure value in years:");
            tenure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inerest rate will be of 9%");
            emi = (int)((loan_amt * tenure) / ((5 + 0.9) * tenure - 1));
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Loan summary:");
            Console.WriteLine("Account holder name:" + name);
            Console.WriteLine("Account number:" + acc);
            Console.WriteLine("Monthly EMI:" + emi);
            Console.WriteLine("Loan amount:" + loan_amt);
            Console.WriteLine("Total payable:" + ((emi * 12) - loan_amt));
            Console.WriteLine("Interest payable:" + (emi * 12));

        }
        public override void header()
        {
            Console.WriteLine("\n_______________________________________Welcome to Loan module.________________________________________________");
        }

        public static void Main(string[] args)
        {
            int ch;
            
            bank_sys ob1 = new bank_sys();
            ob1.header();
            loan ob = new loan();
            ob.getdata();
           
            do
            {
                Console.WriteLine("\n___________________Menu____________________\n");
                Console.WriteLine("1.Deposit\n2.Withdreaw\n3.Loan\n4.Display\n5.Exit");
                Console.WriteLine("\n___________________________________________\n");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: ob.deposit(); break;
                    case 2: ob.withdraw(); break;
                    case 3: ob.header();
                            ob.loan_sys();
                        break;
                    case 4: ob.display(); break;
                    case 5: break;
                    default: Console.WriteLine("Invalid choice"); break;


                }
            } while (ch != 6);
        }
    }
}
