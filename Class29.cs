using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Csharp
{
    class Class29
    {
        static void Main(string [] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 4)
                    {
                        Console.Write(1);
                    }
                    else if (i != 0 || i != 4)
                    {
                        if (i == 2 || i == 3)
                        {
                            if (i + j == 5)
                            {
                                Console.Write(0);
                            }
                            else if (i == 2 && j == 1) {
                                Console.Write(0);

                            }
                            else if (i == 3 && j == 1)
                            {
                                Console.Write(0);
                            }
                            else
                            {
                                Console.Write(1);
                            }
                        }
                        if (i == 1 &&( j==2 || j == 3))
                        {
                            Console.Write(0);
                        }
                        else if(i==1 &&(j!=2 || j!=3))
                        {
                            Console.Write(1);
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
