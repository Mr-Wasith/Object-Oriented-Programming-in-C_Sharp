using System;
using System.Runtime.InteropServices;
namespace Constructor_Overloading
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor without parameter");
        }
        public Program(int n)
        {
            Console.WriteLine("Constructor with parameter");
        }
        static void Main(string[] args)
        {
            Program p = new Program();  
            //Program p1 = new Program(3);

        }
    }
}
