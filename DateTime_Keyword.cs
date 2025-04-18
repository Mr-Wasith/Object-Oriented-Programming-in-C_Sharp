using System;

namespace AgeVerification
{
    public class UnderageException : Exception
    {
        public UnderageException(string message) : base(message) { }
    }

    public class AgeCalculator
    {
        public  int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Adjust age if birthdate hasn't occurred yet this year
            if (birthDate > today.AddYears(-age)) age--;

            return age;
        }

        public void VerifyAge(DateTime birthDate)
        {
            int age = CalculateAge(birthDate);

            if (age < 18)
            {
                throw new UnderageException("Age is less than 18. Access is not allowed.");
            }
            else
            {
                Console.WriteLine("Access granted. Age is " + age);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your birthdate (yyyy-mm-dd): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                AgeCalculator ob = new AgeCalculator();
                ob.VerifyAge(birthDate);
            }
            catch (UnderageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
            }
        }
    }
}
