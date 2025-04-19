using System;
namespace Interface_Inheritance
{
    interface I1
    {
        void print();
    }
    interface I2
    {
        void print1();
    }
    interface I3 : I1,I2
    {
        void print2();
    }

    class Program : I3
    {
        public void print2()
        {
            Console.WriteLine("This is a method of Interface 3");
        }
        public void print()
        {
            Console.WriteLine("This is a method of Interface 1");
        }
        public void print1()
        {
            Console.WriteLine("This is a method of Interface 2");
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
            p.print1();
            p.print2();
            Console.WriteLine();

            I1 i1 = new Program();
            i1.print();
            Console.WriteLine();

            I2 i2 = new Program();
            i2.print1();
            Console.WriteLine();

            I3 i3 = new Program();
            i3.print();
            i3.print1();
            i3.print2();
            Console.WriteLine();
        }
        
    }



}