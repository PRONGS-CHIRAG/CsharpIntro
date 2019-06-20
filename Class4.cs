using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{//question4
    class Class4
    {
        static void Main(string[] args)
        {
            char[] sentence = new char[100];

            int i, vowels = 0, consonants = 0, special = 0,spaces=0, n;
            Console.WriteLine("Enter the Length of the sentence  \n");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                sentence[i] = Convert.ToChar(Console.Read());
            }
            for (i = 0; sentence[i] != '\0'; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
                'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
                (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }
                else
                {
                    consonants = consonants + 1;
                }
                if (sentence[i] == 't' || sentence[i] == '\0' )
                {
                    special = special + 1;
                }
                if (sentence[i] == ' ')
                {
                    spaces += 1;
                }
            }

            consonants = consonants - special;
            Console.WriteLine("No. of vowels {0}", vowels);
            Console.WriteLine("No. of consonants {0}", consonants);
            Console.WriteLine("No of spaces {0}", spaces);
            Console.WriteLine("No of words {0}", spaces + 1);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
*/