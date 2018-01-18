using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[5];
            Console.WriteLine("Input 5 integers to print them out in reverse order.");
            for (int i = 0; i < 5; i++)
            {
                intarray[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Reversed:");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(intarray[i]);
            }
            Console.ReadKey(true);
        }
    }
}
