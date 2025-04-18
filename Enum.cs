using System;
namespace Enums
{
    enum Days
    {
        Sunday, //0
        Monday, //1
        Tuesday, //2
        Wednesday, //3
        Thursday, //4
        Friday, //5
        Saturday //6
    }

    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Days birthDay = Days.Tuesday;
            Months birthMonth = Months.January;
            Console.WriteLine(birthDay);
            Console.WriteLine(birthMonth);

            Days myDay = (Days)2;
            Console.WriteLine(myDay);

            Months myMonth = (Months)5;
            Console.WriteLine(myMonth);

            int val1 = (int) Days.Saturday;
            Console.WriteLine(val1);

            int val2 = (int) Months.February;
            Console.WriteLine(val2);

            string[] Day = (string[]) Enum.GetNames(typeof(Days));
            foreach (string day in Day)
            {
                Console.WriteLine(day);
            }

            int[] value = (int[]) Enum.GetValues(typeof(Months));
            foreach(int val in  value)
            {
                Console.WriteLine(val); 
            }


        }
    }
}

