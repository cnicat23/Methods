using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            string[] str = { "a", "b", "c", "e" };
            string[] newstr = { "d", "a", "b", "d" };
            SameString(str, newstr);

            //task 2.1 kohne task
            int[] arr = { 1, 2, 3 };
            int[] newarr = { 4, 5, 6 };
            ResultNumber(arr, newarr);

            //task 2.2 yeni task
            ResultSameIndexNumber(arr, newarr);

            //task 3
            string[] str3 = { "Anar", "behruz", "Ferid", "Ismayil" };
            char firstLetter = Convert.ToChar(Console.ReadLine().ToLower());
            ResultNewLetter(str3, firstLetter);

            //task 4
            //Area deyə Method(lar) yaradın
            //a.Çevrənin sahəsi -S = p * r² (p = 3)
            Area(12);

            //b.Düzbucaqlının sahəsi -S = a * b    
            Area(6, 7);

            //c.Düzbucaqlı paralelpipedin tam səthinin sahəsi - S = 2(a * b + a * c + b * c)
            Area(2, 5, 8);

            //d.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2
            Area(2, 4, 6, 8);
        }

        // task 1

        static void SameString(string[] str, string[] newstr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (global::System.Int32 j = 0; j < newstr.Length; j++)
                {
                    if (str[i] == newstr[j])
                    {
                        Console.WriteLine(str[i]);
                    }
                }
            }
        }

        //task 2.1 kohne task
        static void ResultNumber(int[] arr, int[] newarr)
        {
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];

            }
            for (global::System.Int32 j = 0; j < newarr.Length; j++)
            {
                result *= newarr[j];
            }

            Console.WriteLine(result);
        }

        //task 2.2 yeni task

        static void ResultSameIndexNumber(int[] arr, int[] newarr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] += arr[i] * newarr[i];
                Console.WriteLine(result[i]);
            }
        }

        //task 3
        static void ResultNewLetter(string[] str3, char firstLetter)
        {
            for (int i = 0; i < str3.Length; i++)
            {
                str3[i] = str3[i].ToLower();
                if (firstLetter == str3[i][0])
                {
                    Console.WriteLine(str3[i]);
                }
            }
        }

        //task 4
        static void Area(int r)
        {
            int p = 3;
            int S = p * (r * r);
            Console.Write("Cevrenin sahesi - ");
            Console.WriteLine(S);

        }
        static void Area(int a, int b)
        {
            int S = a * b;
            Console.Write("Duzbucaqlinin sahesi - ");
            Console.WriteLine(S);
        }
        static void Area(int a, int b, int c)
        {
            int S = 2 * (a * b + a * c + b * c);
            Console.Write("Duzbucaqli paralelpipedin tam sethinin sahesi - ");
            Console.WriteLine(S);

        }
        static void Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;

            Console.Write("Ucbucaqlinin daxiline cekilmis cevrenin sahesi - ");
            Console.WriteLine(S);

        }
    }
}
