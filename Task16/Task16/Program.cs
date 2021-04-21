using System;
using System.Numerics;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            BigInteger number = BigInteger.Pow(2, 1000);

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
