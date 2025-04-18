using System;
namespace Delegate
{
    delegate void Calculator(int x,int y);

    class Program
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Mul(int x,int y)
        {
            Console.WriteLine(x * y);
        }

        static void Main(string[] args)
        {
            Calculator cal = new Calculator(Add);
            cal(20, 30);
            Calculator cal2 = new Calculator(Mul);
            cal2(20, 30);

            //Multicast Delegate 
            cal += cal2;
            cal(2, 3);

            //Anonymous Delegate
            //IN this case, We don't need to declare Add and Mul Method
            Calculator CalAdd = delegate (int x, int y)
            {
                Console.WriteLine(x + y);
            };
        }
    }
}
