using System;
/**
 Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.
  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 
  610, 987, 1597, 2584, 4181, 6765 , 10946, 17711, 28657,
  46368, 75025, 121393, 196418, 317811, 514229, 832040, 
  1346269, 2178309, 3524578 

*/

namespace Task2
{
    class Program
    {
        static long sum;
        static void Main(string[] args)
        {
            Console.WriteLine($"{sumFib(2, 3)}");
        }

        static long sumFib(long lastFib, long currentFib)
        {
            long newFib = currentFib + lastFib;
            if (newFib > 4000000)
            {
                return sum;
            }
            if ((newFib) % 2 == 0)
            {
                sum = sum + newFib;
            }

            return sumFib(currentFib, newFib);
        }
    }
}
