using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>intarray1 = new List<int> { 10, 20, 30, 40, 50 };
            List<int>intarray2 = new List<int> { 5, 15, 25, 35, 45 };
            List<int> newArray = new List<int>();
            newArray.AddRange(intarray1);
            newArray.AddRange(intarray2);
            newArray.Sort();
            foreach (int element in newArray)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey(true);
        }
    }
}
