using System;

namespace task002
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[] array)
            {
                int len = array.Length;
                for(int i = 0; i < len; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Random rnd = new Random();
            int [] array = new int[12];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-9,9);
            }
            int len = array.Length;
            int posSum = 0;
            int negSum = 0;
            for(int i = 0; i < len; i++)
            {
                if(array[i] > 0)
                {
                    posSum = posSum + array[i];
                }
                else
                {
                    negSum = negSum + array[i];
                }
            }
            PrintArray(array);
            Console.WriteLine($"Сумма положительных чисел = {posSum}");
            Console.WriteLine($"Сумма отрцительных чисел = {negSum}");
        }
    }
}
