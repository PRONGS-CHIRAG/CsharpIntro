using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    class Class18
    {
        static void Main(string [] args)
        {
            int rem = 0,sum=0,counte=0,counto=0,se=0,so=0;
            Console.WriteLine("Enter a number");
            string ab = Console.ReadLine();
            int a = Convert.ToInt32(ab);
            ArrayList b = new ArrayList();
            while (a != 0)
            {
                rem = a % 10;
                b.Add(rem);
                sum = sum + rem;
                a = a / 10;

            }
            for(int i = b.Capacity-1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    se = se + Convert.ToInt32(b[i]);
                    counte++;
                }
                if(i%2 == 0)
                {
                    so += Convert.ToInt32(b[i]);
                    counto++;
                }
                Console.WriteLine("{0}:{1}", b[i], b.Capacity - i-1);
            }
            Console.WriteLine(sum);
            Console.WriteLine(se);
            Console.WriteLine(so);
            Console.WriteLine(counte);
            Console.WriteLine(counto);
            Console.ReadLine();

        }
    }
}
*/