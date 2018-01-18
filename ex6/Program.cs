using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int answer = RNG.Next(0, 101);
            int input;
            Console.WriteLine("Guess my number! Between 0 and 100.");
            input = Int32.Parse(Console.ReadLine());
            while (input != answer)
            {
                if (input < answer)
                    Console.WriteLine("Wrong! Try again. The number is larger than your given one.");
                if (input > answer)
                    Console.WriteLine("Wrong! Try again. The number is smaller than your given one.");
                input = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Correct! Congrats!");
            Console.ReadKey(true);
        }
    }
}
