using System;

namespace pi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Please give a number as 1st variable: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give a number as 1st variable: ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value of the 1st variable: " + a);
            Console.WriteLine("The value of the 1st variable: " + b);

        }
    }
}
