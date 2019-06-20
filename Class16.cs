using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    class Class16
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int c = Convert.ToInt32(Console.ReadLine());
            string a_string = Convert.ToString(a);
            string b_string = Convert.ToString(b);
            string c_string = Convert.ToString(c);
            ArrayList sizes = new ArrayList();
            int large = 0;
            sizes.Add(a_string.Length);
            sizes.Add(b_string.Length);
            sizes.Add(c_string.Length);
            for (int i= 0; i < sizes.Capacity-1; i++)
            {
                if (Convert.ToInt32(sizes[i]) > large)
                {
                    large = Convert.ToInt32(sizes[i]);
                }  
            }
            int a_space = large - a_string.Length;
            int b_space = large - b_string.Length;
            int c_space = large - c_string.Length;
            string q = "",r="",s="";
            for(int j = 0; j <= a_space; j++)
            {
                q = q + " ";
            }
            for (int j = 0; j <= b_space; j++)
            {
                r = r + " ";
            }
            for (int j = 0; j <= c_space; j++)
            {
                s = s + " ";
            }
            Console.WriteLine(q + a_string);
            Console.WriteLine(r + b_string);
            Console.WriteLine(s + c_string);
            Console.ReadLine();



        }
    }
}
*/