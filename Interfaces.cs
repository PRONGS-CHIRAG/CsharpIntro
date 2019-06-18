using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Intro_Csharp
{
    public interface ITransactions
    {
        void showtransaction();
        double GetAmount();
    }
    public class Transaction : ITransactions
    {
        public string code;
        public string date;
        public double amount;
        public Transaction()
        {
            code = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c,string d, double e)
        {
            code = c;
            date = d;
            amount = e;
        }
        public double GetAmount()
        {
            return amount;
        }
        public void showtransaction()
        {
            Console.WriteLine("Transaction code : {0}", code);
            Console.WriteLine("Transaction date : {0}", date);
            Console.WriteLine("Transaction amount : {0}", GetAmount());
        }
    }

    class Interfaces
    {
        static void Main(string [] args)
        {
            Transaction a = new Transaction("001","4/12/2017",45098.76);
            Transaction b = new Transaction("002", "8/2/2017", 195098.76);
            Transaction c = new Transaction();
            Console.WriteLine("Enter date");
            c.date = Console.ReadLine();
            Console.WriteLine("Enter amount");
            string d = Console.ReadLine();
            c.amount = Convert.ToDouble(d);
            Console.WriteLine("Enter id");
            c.code = Console.ReadLine();

            a.showtransaction();
            b.showtransaction();
            c.showtransaction();
            Console.ReadLine();
        }
    }
}
*/