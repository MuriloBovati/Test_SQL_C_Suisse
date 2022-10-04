using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Suisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Credit Suisse Test");
            Database database = new Database();
            database.getListTrades();
            Console.WriteLine("press any button to close");
            Console.ReadLine();
        }
    }
}
