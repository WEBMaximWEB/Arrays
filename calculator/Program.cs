using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] array2 = { 2, 3, 4 };

            string text1 = "";
            foreach (int i in array1)
            {
                text1 += i.ToString();
            }
            Console.WriteLine(text1);

            string text2 = "";
            foreach (int i in array2)
            {
                text2 += i.ToString();
            }
            Console.WriteLine(text2);

            Console.WriteLine(text1.Contains(text2));
        }
    }
}