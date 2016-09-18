using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_USD_To_BGN_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            if (usd < 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                double bgn = usd * 1.79549;
                Console.WriteLine(Math.Round(bgn, 2));
            }
        }
    }
}
