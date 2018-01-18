using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Input 5 ski-jump scores as integers.");
            List<int> intarray = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                intarray.Add(Int32.Parse(Console.ReadLine()));
            }
            intarray.Sort();
            sum += intarray[1];
            sum += intarray[2];
            sum += intarray[3];
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey(true);
        }
    }
}
