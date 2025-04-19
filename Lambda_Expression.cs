using System;

namespace Lambda_Expression
{
    public delegate void MyDelegate(int n);

    public delegate int MyDelegate2(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous function
            MyDelegate obj = delegate (int a)
            {
                a += 5;
                Console.WriteLine(a);
            };
            obj(10);



            //Lambda Expression
            MyDelegate obj2 = a =>
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj2(10);

            //Just return type in Integer
            MyDelegate2 ob3 = (a,b) => 
            {
                int add = a + b;
                return add;
                
            };
            Console.WriteLine(ob3(20, 10));

        }

    }
}