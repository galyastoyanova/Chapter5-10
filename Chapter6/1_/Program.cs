using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
                Console.WriteLine(i);
        }
    }
}
