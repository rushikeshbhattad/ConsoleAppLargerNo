using System;

namespace LargestNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter any 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Value of a {0} is greatest", a);
                }
                else
                {
                    Console.WriteLine("Value of b {0} is greatest", b);
                }
            }
            else//a<b
            {
                if (b > c)
                {
                    Console.WriteLine("Value of b {0} is greatest", b);
                }
                else
                {
                    Console.WriteLine("Value of c {0} is greatest", c);
                    Console.ReadKey();
                }
            }
        }
    }
}