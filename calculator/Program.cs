using System;
using System.Collections.Generic;
using System.Globalization;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] array2 = { 3, 4, 5 };

            string text1 = Distribution(array1);
            string text2 = Distribution(array2);

            Console.WriteLine(text1.Contains(text2));

            Console.WriteLine(Check(array1));
        }

        static string ArrayToString(Array x)
        {
            string text = "";
            foreach (int i in x)
                text += i.ToString();
            return text;
        }

        static string Check(Array x)
        {
            string str = "";
            int k = 0;
            foreach (int i in x)
            {
                k++;
                if (k < x.Length / x.Rank)
                    str += i.ToString();
                else
                {
                    k = 0;
                    str += i.ToString() + " ";
                }
            }
            return str;
        }

        static string Distribution(Array x)
        {
            string str = "";
            if (x.Rank == 1)
                str = ArrayToString(x);
            else
                str = Check(x);
            return str;
        }
    }
}