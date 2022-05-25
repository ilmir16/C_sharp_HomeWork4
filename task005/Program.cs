using System;

namespace task005
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
            int len = array.Length;
            for(int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
            PrintArray(array);
            int j = len - 1;
            for(int i = 0; i < len / 2; i++)
            {
                while(j > 0)
                {
                    Console.WriteLine($"Произведение элементов {i} и {j} = {array[i]} * {array[j]} = {array[i] * array[j]}");
                    break;
                }
                j = j - 1;  
            }
        }
    }
}
