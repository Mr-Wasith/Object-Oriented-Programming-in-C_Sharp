using System;
namespace Operator_Overloading
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD(int i, int j, int k) 
        {
            x = i;
            y = j; 
            z = k;
        }
        public static ThreeD operator +(ThreeD obj1 , ThreeD obj2)
        {
            ThreeD obj3 = new ThreeD(0,0,0);
            obj3.x = obj1.x + obj2.x;
            obj3.y = obj1.y + obj2.y;
            obj3.z = obj1.z + obj2.z;
            return obj3;
        }
        public static ThreeD operator -(ThreeD obj1, ThreeD obj2)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x - obj2.x;
            obj3.y = obj1.y - obj2.y;
            obj3.z = obj1.z - obj2.z;
            return obj3;
        }
        public static ThreeD operator *(ThreeD obj1, ThreeD obj2)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x * obj2.x;
            obj3.y = obj1.y * obj2.y;
            obj3.z = obj1.z * obj2.z;
            return obj3;
        }
        public static ThreeD operator /(ThreeD obj1, ThreeD obj2)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x / obj2.x;
            obj3.y = obj1.y / obj2.y;
            obj3.z = obj1.z / obj2.z;
            return obj3;
        }
        public static ThreeD operator %(ThreeD obj1, ThreeD obj2)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x % obj2.x;
            obj3.y = obj1.y % obj2.y;
            obj3.z = obj1.z % obj2.z;
            return obj3;
        }
        public static ThreeD operator ++(ThreeD obj1)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x + 1;
            obj3.y = obj1.y + 1;
            obj3.z = obj1.z + 1;
            return obj3;
        }
        public static ThreeD operator --(ThreeD obj1)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x - 1;
            obj3.y = obj1.y - 1;
            obj3.z = obj1.z - 1;
            return obj3;
        }
        public static ThreeD operator +(ThreeD obj1, int z)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = obj1.x + z;
            obj3.y = obj1.y + z;
            obj3.z = obj1.z + z;
            return obj3;
        }
        public static ThreeD operator -(ThreeD obj1)
        {
            ThreeD obj3 = new ThreeD(0, 0, 0);
            obj3.x = -obj1.x;
            obj3.y = -obj1.y;
            obj3.z = -obj1.z;
            return obj3;
        }
        public void show()
        {
            Console.WriteLine(" " + x + ", " + y + ", " + z);
        }
    }
    class Program
    {
        public static void Main(string[] args) 
        {
            ThreeD obj1 = new ThreeD(4,6,8);
            ThreeD obj2 = new ThreeD(2,3,4);
            ThreeD obj3 = new ThreeD(0,0,0);

            //obj3 = obj1 + obj2;
            //obj3.show();
            //obj3 = obj1 - obj2;
            //obj3.show();
            //obj3 = obj1 * obj2;
            //obj3.show();
            //obj3 = obj1 / obj2;
            //obj3.show();
            //obj3 = obj1 % obj2;
            //obj3.show();
            obj3 = obj1++;
            obj3.show();
            obj1--;
            obj3 = obj3--;
            obj3.show();
            obj1++;
            obj3 = obj1 + 5;
            obj3.show();
            obj3 = -obj1;
            obj3.show();
        }
    }
}
