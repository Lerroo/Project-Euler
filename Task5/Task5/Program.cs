using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2500; i < 999999999999999L; i++)
            {
                if (check(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        public static bool check(int number)
        {
            var posibleDividers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (var posibleD in posibleDividers)
            {
                if (number % posibleD != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
