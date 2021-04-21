using System;

namespace Task1
{
    class Program
    {
        const int maxValue = 999;
        static void Main(string[] args)
        {
            int la = sumProgressia(3) + sumProgressia(5) - sumProgressia(15);
            Console.WriteLine($"{la}");
        }

        static int sumProgressia(int step)
        {
            return step * (maxValue / step) * ((maxValue / step) + 1) / 2;
        }
    }
}
