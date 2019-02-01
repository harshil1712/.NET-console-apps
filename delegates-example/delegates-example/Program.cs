using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_example
{
    class Program
    {

        public delegate void addNum(int a, int b);
        public delegate void subNum(int a, int b);
        public delegate void divNum(int a, int b);
        public delegate void mulNum(int a, int b);

        public void add (int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void div(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        public void  mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Main(string[] args)
        {
            int userInput, a, b;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("For Addtion enter 1");
            Console.WriteLine("For Subtraction enter 2");
            Console.WriteLine("For Division enter 3");
            Console.WriteLine("For Multiplication enter 4");
            userInput = Convert.ToInt16(Console.ReadLine());
            Program obj = new Program();
            switch (userInput)
            {
                case 1:
                    addNum sum = new addNum(obj.add);
                    sum(a, b);
                    break;
                case 2:
                    addNum diff = new addNum(obj.sub);
                    diff(a, b);
                    break;
                case 3:
                    addNum quo = new addNum(obj.div);
                    quo(a, b);
                    break;
                case 4:
                    addNum pro = new addNum(obj.mul);
                    pro(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    return;
            }
            
            Console.Read();
        }
    }
}
