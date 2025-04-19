using System;

namespace Exp_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // DivideByZero Exception Handling
            try
            {
                Console.Write("Enter n (numerator): ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Enter m (denominator): ");
                int m = int.Parse(Console.ReadLine());

                int result = n / m;
                Console.WriteLine("Division Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can not divide by zero");
            }

            // IndexOutOfRange Exception Handling 
            try
            {
                Console.Write("Enter index to store value in an array of size 3: ");
                int index = int.Parse(Console.ReadLine());

                int[] arr = new int[3];
                arr[index] = 100; 
                Console.WriteLine("Value stored at index " + index);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range exception is happened");
            }

            // Null Reference Exception Handling 
            try
            {
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    name = null;
                }

                Console.WriteLine("Length of your name: " + name.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception..String is null");
            }

            // Format Exception Handling 
            try
            {
                Console.Write("Enter a valid integer: ");
                string number = Console.ReadLine();

                int num = int.Parse(number);
                Console.WriteLine("Number is = " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception is Happened");
            }

            Console.WriteLine("Remaining Statement");
            Console.WriteLine("Remaining Statement");
            Console.WriteLine("Remaining Statement");
        }
    }
}
