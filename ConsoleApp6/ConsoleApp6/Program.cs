using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("****This program will give the sum of 5 prices********");
            Console.WriteLine("*******************************************************");
            double result = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"please enter a price of items{i}:");
                total = total + double.parse(Console.ReadLine());
            }
            Console.WriteLine($"The total of those items is :${total}");
            Console.ReadLine();


        }
    }
}
