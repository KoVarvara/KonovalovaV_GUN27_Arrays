using System;

namespace Homework
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1:");

            int[] arrayFibonacci = new int[8];
            for (int i = 0; i < arrayFibonacci.Length; i++)
            {
                if (i == 0)
                {
                    arrayFibonacci[0] = 0;
                }
                else if (i == 1)
                {
                    arrayFibonacci[1] = 1;
                }
                else
                {
                    arrayFibonacci[i] = arrayFibonacci[i - 1] + arrayFibonacci[i - 2];
                }
                Console.WriteLine(arrayFibonacci[i]);
            }

            //Task 2
            Console.WriteLine("Task 2:");

            string[] arrayMonths = new string[] {"January","February","March","April","May","June","July","August","September","October","November","December"};
            for (int i = 0; i < arrayMonths.Length; i++)
            {
                Console.WriteLine(arrayMonths[i]);
            }

            //Task 3
            Console.WriteLine("Task 3:");

            int number1 = 2;
            int number2 = 3;
            int number3 = 4;

            int[,] arrayMatrix = new int[,] { { number1, number2, number3 }, { number1, number2, number3 }, { number1, number2, number3 } };

            for (int i = 0; i < arrayMatrix.GetLength(0); i++)
            {
                int exponent = i + 1;
                for (int j = 0; j < arrayMatrix.GetLength(1); j++)
                {
                    arrayMatrix[i, j] = (int)Math.Pow(arrayMatrix[i, j], exponent);
                    Console.WriteLine(arrayMatrix[i, j]);
                }
            }

            //Task 4
            Console.WriteLine("Task 4:");

            double[][] jaggedArray = new double[][] {new double [] {1f,2f,3f,4f,5f}, new double [] {Math.E, Math.PI}, new double [] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)}};
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

            // массивы для заданий 5 и 6.
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            //Task 5 
            Console.WriteLine("Task 5:");

            Array.Copy(array, array2, 3);
            foreach (var a in array2)
            {
                Console.WriteLine(a);
            }

            //Task 6
            Console.WriteLine("Task 6:");

            Array.Resize(ref array, array.Length * 2);
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }                   
}
