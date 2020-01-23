using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   class Accounts
    {
        int accountno;
        string name;
       int tryType;
        string accType;
        double balance;
        double amount;
        public  Accounts()
        {

        }

        public Accounts(int accountno, string name, string accType,double amount)
        {
            this.accountno = accountno;
            this.name = name;
            this.accType = accType;
            this.balance = amount;
        }

        public void credit(Double amount)
        {
            this.tryType = 0;
          this.balance  =this.balance+ amount;


        }
        public void  Debit( Double amount)
        {
            this.tryType = 1;
            this.balance = this.balance - amount;

        }
        public void showd()
        {
            Console.WriteLine("showing details of the transcation");
            Console.WriteLine("account holder name:" + this.name + "\n" + "account number:" + this.accountno + "\n" + "account balance" + this.balance + "\n" + "transaction type is " + this.tryType);
        }
    }
    class Program
    {
        Accounts a = new Accounts();
        static void Main(string[] args)
        {
            int balance = 10000000;

            Console.WriteLine("enter account number");
            int accountno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter account holder name");
            string name = Console.ReadLine();
            Console.WriteLine("enter account type");
            string accType = Console.ReadLine();
           Accounts ac1 = new Accounts(accountno, name, accType,amount);
            Console.WriteLine("enter transaction type");
           int tType = int.Parse(Console.ReadLine());
            if (tType == 0)
            {
                Console.WriteLine("enter amount to depsit");
                double amount = Double.Parse(Console.ReadLine());
                ac1.credit(amount);
            }
            else if (tType == 1)
            {
                Console.WriteLine("enter amount to withdraw");
                double amount = Double.Parse(Console.ReadLine());
                ac1.Debit(amount);
            }
            else
                Console.WriteLine("invalid");

            ac1.showd();


            
            
            Console.ReadKey();
        }
    }
}
