﻿using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(addEven(arr));

            Func<int, bool> even = (x) => x % 2 == 0;
            Func<int, bool> odd = (x) => x % 2 == 1;
            Func<int, int> minusOne = (x) => x - 1;

            Func<int, string> hello = (x) => "hello";

            var arr2 = Enumerable.Range(1, 100).Where(even).ToList();
            var arr3 = Enumerable.Range(1, 100).Where(odd).ToList();

            //arr2.ForEach(Console.WriteLine);
            //arr3.ForEach(Console.WriteLine);

            int[,] arr2d = { { 1, 2, 3 }, { 4, 5, 6 } };

            var result = addNumsFromFile("numbers.txt");

            Console.WriteLine(result);

        }

        public static int addEven(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {

                    result += arr[i];
                }
            }
            return result;
        }

        public static string reverse(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        public static string reverseIterative(string str)
        {
            var result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {

                result += str[i];
            }

            return result;
        }

        public static void multiplication(int num)
        {

            for (int i = 1; i <= num; i++)
            {

                for (int j = 1; j <= num; j++)
                {
                    Console.Write(i * j + "\t");

                }
                Console.WriteLine();
            }

        }

        public static string reverseInPlace(string str)
        {

            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = reverse(arr[i]);
            }

            return string.Join(" ", arr);
        }

        public static Tuple<int, int> parseArray(int[,] arr, int key)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {



                    if (arr[i, j] == key)
                    {

                        return Tuple.Create(i, j);
                    }
                }
            }

            return Tuple.Create(-1, -1);
        }

        public static int fib(int num)
        {

            if (num < 2)
            {
                return num;
            }

            return fib(num - 1) + fib(num - 2);
        }

        public static int largest(int[] arr)
        {

            var max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int addNumsFromFile(string file)
        {
            int result = 0;

            using (StreamReader sr = File.OpenText(file))
            {

                String line;

                while ((line = sr.ReadLine()) != null)
                {
                    result += Convert.ToInt32(line);
                }

            }
            return result;
        }
    }
}
