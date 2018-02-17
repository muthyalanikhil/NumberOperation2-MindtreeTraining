using System;
using System.Collections.Generic;
using NumberOperationTest;

namespace NumberOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Number add = new Number();
            int sum = add.AddDigits(number);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
