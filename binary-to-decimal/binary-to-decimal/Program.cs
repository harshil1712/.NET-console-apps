using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            String no = "";
            int dec_value = 0;
            int base1 = 1;
            Console.Write("Enter the binary no. ");
            no = Console.ReadLine();

            num = Convert.ToInt32(no);

            int temp = num;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            Console.Write(dec_value);
            Console.Read();
        }
    }
}
