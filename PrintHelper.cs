﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    class PrintHelper
    {
      
					
public class Program
    {

        public static void Main()
        {
            Number myNumber = new Number(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
                Console.ReadLine();
        }
    }

    class Number
    {
        private PrintHelper1 _printHelper;

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper1();
            //subscribe to beforePrintEvent event
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }
        //beforePrintevent handler
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }

    public class PrintHelper1
    {
        // declare delegate 
        public delegate void BeforePrint();

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;

        public PrintHelper1()
        {

        }

        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }


}
}
*/