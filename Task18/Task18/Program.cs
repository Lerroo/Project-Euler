using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"3
7 4
2 4 6
8 5 9 3";


            List<int> numbers = Regex.Matches(text, "\\b\\d{1,2}\\b").Select(f => Convert.ToInt32(f.Value))
                       .ToList();
            int n = text.Count(f => f == '\n')+1;
            int[][] matr = new int[n][];

            var enumerator = numbers.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < n; ++i)
            {
                matr[i] = new int[i+1];
                for (int j = 0; j < i+1; ++j)
                {
                    matr[i][j] = Convert.ToInt32(enumerator.Current);
                    enumerator.MoveNext();
                    

                }
            }

            foreach (var item in matr)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");

                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = matr[i].Length-1; j > 0; j--)
                {
                    if (matr[i][j] > matr[i][j-1])
                    {
                        matr[i - 1][j - 1] += matr[i][j];
                    }
                    else
                    {
                        matr[i - 1][j - 1] += matr[i][j-1];
                    }
                }
                
            }
            Console.WriteLine(matr[0][0]);
        }
    }
}
