using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of rows of stars as an integer.");
            int amount = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < amount;i++)
            {               
                for (int p = i; p > 0; p--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey(true);
        }
    }
}
