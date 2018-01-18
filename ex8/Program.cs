using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string.");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < input.Length; i++)
            {
                sb[i] = input[input.Length - 1 - i];
            }
            Console.WriteLine(sb.ToString());
            if (sb.ToString().Equals(input))
                Console.WriteLine("Is palindrome.");
            else
                Console.WriteLine("Not a palindrome.");
            Console.ReadKey(true);
        }
    }
}
