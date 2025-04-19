using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
        
        //Sorting in Accending Order
        numbers.Sort((a, b) => a.CompareTo(b)); 

        //Print in Accending order 
        Console.Write("Sorted list:");
        //numbers.ForEach(n => Console.Write(n + " "));

        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        //Sorting in Descending Order
        numbers.Sort((a, b) => b.CompareTo(a));

        //Print in Descending order 
        Console.Write("Sorted list:");
        //numbers.ForEach(n => Console.Write(n + " "));

        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
    }
}

