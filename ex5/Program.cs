using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int iteration = 0;
            Console.WriteLine("Input length of a tree to print as an integer");
            size = Int32.Parse(Console.ReadLine());

            Console.Write("*");
            for (int p = 0; p < size; p++)
            {
                Console.WriteLine("*");
                for (int i = 0; i < iteration; i++)
                {
                    Console.Write("*");
                    Console.Write("*");
                }

                for (int i = 0; i < size - 2; i++)
                {
                    if (i < size - 3)
                        Console.Write(" ");
                    if (i >= size - 3)
                    {
                        Console.Write("*");
                        Console.Write("*");
                    }
                }
            }
        }
    }
}
