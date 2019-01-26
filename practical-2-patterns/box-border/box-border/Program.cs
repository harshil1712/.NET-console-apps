using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box_border
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 4)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if(j ==0 || j==4)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                }
                Console.WriteLine();
                
            }
            Console.Read();
        }
    }
}
