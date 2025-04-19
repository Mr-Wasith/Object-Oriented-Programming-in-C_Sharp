using System;
namespace Exp_Handling
{
    public class UserDefineException : Exception
    {
        public UserDefineException(string s) : base(s)
        {

        }
    }

    class Program
    {

        static void Check(int i)
        {
            if (i < 18)
            {
                throw new UserDefineException("Age is not valid");
            }
            else
            {
                Console.WriteLine("Age is Valid");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Check(18);

            }
            catch (UserDefineException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}