using System;

namespace Recursion
{
    class Program
    {
        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        public static int PrintNatural(int start, int value)
        {
            if (value < 1)
            {
                return start;
            }
            value--;
            Console.Write(" {0} ", start);
            return PrintNatural(start + 1, value);
        }

        static void Main(string[] args)
        {
            int result = 0;
            result = Factorial(5);
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------");

            PrintNatural(1, 10);

            Console.Read();
        }
        
    }
}
