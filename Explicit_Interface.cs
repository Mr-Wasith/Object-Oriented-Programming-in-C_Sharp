using System;
namespace Explicit_Interface
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }

    class Myclass : I1, I2
    {
        void I1.show()
        {
            Console.WriteLine("Method of Interface 1");
        }
        void I2.show()
        {
            Console.WriteLine("Method of Interface 2");
        }

    }

    class Program
    {
        public static void Main(string[] args) 
        {
            // One way
            Myclass ob = new Myclass();
            ((I1)ob).show();
            ((I2)ob).show();
            Console.WriteLine();

            // Alternative way
            I1 ob1 = new Myclass();
            ob1.show();
            I2 ob2 = new Myclass();
            ob2.show();

        }
    }
}
