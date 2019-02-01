using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName = "";
            String countryName = "";
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your country:");
            countryName = Console.ReadLine();
            Console.WriteLine("Hello "+userName+" from country "+countryName+"!");
            Console.ReadKey();
        }
    }
}
