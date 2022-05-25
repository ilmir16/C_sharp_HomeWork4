using System;

namespace task004
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
            int [] array = new int[123];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 200);
            }
            int len = array.Length;
            int count = 0;
            for(int i = 0; i < len; i++)
            {
                if(array[i] > 10 && array[i] < 99)
                {
                    count = count + 1;
                }
            }
            PrintArray(array);
            Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");
        }
    }
}
