using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
