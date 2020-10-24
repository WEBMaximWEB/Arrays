using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] array2 = { 1, 2, 3 };

            string text1 = ArrayToString(array1);
            string text2 = ArrayToString(array2);

            Console.WriteLine(text1.Contains(text2));
        }

        static string ArrayToString(Array x)
        {
            string text = "";
            foreach (int i in x)
                text += i.ToString();
            return text;
        }
    }
}