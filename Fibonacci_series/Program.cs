using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,temp;
            Console.Write("Enter the number to limit the series:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(a);
            for (int i = 0; b <= c; i++)
            {
                Console.Write(" "+b);
                temp = b + a;
                a = b;
                b = temp;
            }
            Console.ReadLine();
        }
    }
}
