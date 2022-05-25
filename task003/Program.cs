using System;

namespace task003
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
            int [] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100,1000);
            }
            int len = array.Length;
            int posSum = 0;
            int negSum = 0;
            for(int i = 0; i < len; i++)
            {
                if(array[i] % 2 == 0)
                {
                    posSum = posSum + 1;
                }
                else
                {
                    negSum = negSum + 1;
                }
            }
            PrintArray(array);
            Console.WriteLine($"Количество четных чисел = {posSum}");
            Console.WriteLine($"Количество нечетных чисел = {negSum}");
        }
    }
}
