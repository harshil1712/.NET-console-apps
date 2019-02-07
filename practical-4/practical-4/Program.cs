using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_4
{
    class Bank
    {
        private String name;
        private double credit;
        private double debit;
        private double bal;
        public void display()
        {
            Console.WriteLine("\nName is " + name + " Balance is " + bal);
        }
        public Bank(String x, double y)
        {
            name = x;
            bal = y;
        }
        public Bank()
        {
            name = "N.A";
            credit = 0;
            debit = 0;
            bal = 0;
        }
        public double cred(double amt)
        {
            bal = bal + amt;
            return bal;
        }
        public double deb(double amt)
        {
            bal = bal - amt;
            return bal;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Harshil Agrawal");
            Console.WriteLine("Enrollment No.:160410107001");
            Bank b = new Bank("ABC", 60000);
            double amt, ans;
            int ch;
            while (true)
            {
                Console.WriteLine("\nEnter choice. \n1 for credit \n2 for debit \n3 for display \n4 for exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\nEnter Amount To Be Credit ");
                        amt = double.Parse(Console.ReadLine());
                        ans = b.cred(amt);
                        b.display();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter amount To Be Debit");
                        amt = double.Parse(Console.ReadLine());
                        ans = b.deb(amt);
                        b.display();
                        break;
                    case 3:
                        b.display();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
