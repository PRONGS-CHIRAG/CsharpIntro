using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    class Rectangle_Application
    {
        //declaration of variables
        
        double width,length;
        //function for initializing
        public void Accept_details()
        { 
            string Length_string, Width_string;
            Console.WriteLine("Enter length");
            Length_string = Console.ReadLine();
            Console.WriteLine("Enter width");
            Width_string = Console.ReadLine();
            length = Convert.ToDouble(Length_string);
            width = Convert.ToDouble(Width_string);
            
        }
        //function to compute area
        public double Area(double length,double width)
        {
            return length * width;
        }
        //display function
        public void Display()
        {   
            Console.WriteLine("Length of rectangle : {0}",length);
            Console.WriteLine("Width of rectangle : {0}", width);
            Console.WriteLine("Area of rectangle : {0}", Area(length,width));
        }
    }
    //execution class
    class Execute
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Rectangle_Application a = new Rectangle_Application();
                a.Accept_details();
                a.Display();
                Console.WriteLine("Enter q for exit");
                string b = Console.ReadLine();
                if (String.Compare(b, "q") == 0)
                {
                    return;
                }
            }
        }
    }
}
*/