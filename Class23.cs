using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    class Class23
    {
        public static int INT_MAX { get; private set; }

        static int add(int x,int y)
        {
            while (y != 0)
            {
                int carry = x & y;
                x = x ^ y;
                y = carry << 1;
            }
            return x;
        }
        static int subtract(int x, int y)
        {
            while (y != 0)
            {
                int borrow = (~x) & y;
                x = x ^ y;
                y = borrow << 1;
            }
            return x;
        }
        static int multiply(int x,int y)
        {
            if (y == 0)
            {
                return 0;
            }
            if (y > 0)
            {
                return (x + multiply(x, y - 1));
            }
            if (y < 0)
            {
                return -multiply(x, -y);
            }
            return -1;
        }
        static int divide(int num1,int num2)
        {
            if (num1 == 0)
                return 0;
            if (num2 == 0)
                return 100000000;

            bool negResult = false;

            
            if (num1 < 0)
            {
                num1 = -num1;
                if (num2 < 0)
                    num2 = -num2;
                else
                    negResult = true;
            }
            else if (num2 < 0)
            {
                num2 = -num2;
                negResult = true;
            }

             
            int quotient = 0;
            while (num1 >= num2)
            {
                num1 = num1 - num2;
                quotient++;
            }

           
            if (negResult)
                quotient = -quotient;
            return quotient;
        }
        static void Main(string [] words)
        {
            Console.WriteLine("enter no1");
            string a = Console.ReadLine();
            int aa = Convert.ToInt32(a);
            Console.WriteLine("enter no2");
            string b = Console.ReadLine();
            int bb = Convert.ToInt32(b);
            Console.WriteLine(add(aa, bb));
            Console.WriteLine(subtract(aa, bb));
            Console.WriteLine(multiply(aa, bb));
            Console.WriteLine(divide(aa, bb));
            Console.ReadLine();


        }
    }
}
*/