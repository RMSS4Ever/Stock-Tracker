using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Of_Shares
{
    class Program
    {
        
        static double numberOfShares(double Bank, double StockPrice)
        {
            double result = Bank / StockPrice;

            return result;

        }

        static void Main(string[] args)
        {
            // Variables
            double Bank = 400.00;

            WriteLine("Stock Price: ");
            double stockPrice = Convert.ToDouble(ReadLine());

            double nmbrShares = numberOfShares(Bank, stockPrice);

            WriteLine("Amount of Shares to purchase: " + nmbrShares);

            ReadLine();


        }
    }
}
