using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 0;
            List<int> gradelist = new List<int>();
            Console.WriteLine("Input student grades (values between 0 and 5). Input any letter or whitespace to stop.");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out input) && input >= 0 && input < 6)
                    gradelist.Add(input);
                else if (input > 5 || input < 0)
                    Console.WriteLine("Invalid input. Only numbers between 0 and 5.");
                else
                    break;               
            }

            Console.WriteLine("Grade distribution:");
            for (int p = 0; p < 6; p++)
            {
                Console.Write("{0}:", p);
                for (int i = 0; i < gradelist.Count; i++)
                {
                    if (gradelist[i] == p)
                        Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey(true);
        }
    }
}
