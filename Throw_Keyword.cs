using System;

namespace ThrowKeywordExample
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
    public class Program
    {
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or older.");
            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());
                CheckAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
        }
    }
}
