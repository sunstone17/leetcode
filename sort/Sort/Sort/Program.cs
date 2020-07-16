using System;
using System.Security.Cryptography.X509Certificates;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8] { 10, 11, 9, 8, 2, 3, 1, -1 };

            new Bubble.Bubble().Sort(array);

            Print(array);

            Console.Read();
        }

        static void Print(int[] arr)
        {
            if (arr == null)
            { return; }

            Array.ForEach(arr, x => { Console.WriteLine($"{x},"); });
        }
    }
}
