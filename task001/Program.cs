using System;

namespace task001
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
            int [] array = new int[8];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,2);
            }
            PrintArray(array);
        }
    }
}
