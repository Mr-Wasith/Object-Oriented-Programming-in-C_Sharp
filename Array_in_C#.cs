using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
            int[] arr2 = new int[] { 4, 5, 6, 8, 9 };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            int[] arr3 = { 10, 20, 30, 40, 50};
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]);
                Console.Write(" ");
            }
        }
    }
}

