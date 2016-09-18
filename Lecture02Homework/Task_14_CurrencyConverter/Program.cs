using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string[] currencies = new string[] { "BGN", "USD", "EUR", "GBP" };
            double[] rates = new double[] { 1, 1.79549, 1.95583, 2.53405 };
            var currency_from_input = Console.ReadLine();
            var currency_to_input = Console.ReadLine();
            string currency_from = "", currency_to = "";
            int rate_from_index = 0, rate_to_index = 0;
            double result = 0.00;
            if (amount < 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                for (int i = 0; i < currencies.Length; i++)
                {
                    if (currency_from_input == currencies[i])
                    {
                        currency_from = currency_from_input;
                        rate_from_index = i;
                    }
                    if (currency_to_input == currencies[i])
                    {
                        currency_to = currency_to_input;
                        rate_to_index = i;
                    }
                }
                if (currency_from == "" || currency_to == "")
                {
                    Console.WriteLine("Error! Invalid input!");
                }
                else
                {
                    if (currency_from != currencies[0] && currency_to != currencies[0])
                    {
                        result = (amount * rates[rate_from_index]) / rates[rate_to_index];
                        Console.WriteLine("{0} {1}", Math.Round(result, 2), currency_to);
                    }
                    else if (currency_from == currencies[0] && currency_to != currencies[0])
                    {
                        result = amount / rates[rate_to_index];
                        Console.WriteLine("{0} {1}", Math.Round(result, 2), currency_to);
                    }
                    else if (currency_from != currencies[0] && currency_to == currencies[0])
                    {
                        result = amount * rates[rate_from_index];
                        Console.WriteLine("{0} {1}", Math.Round(result, 2), currency_to);
                    }
                    else
                    {
                        Console.WriteLine("Error! Invalid input!");
                    }
                }
            }
        }
    }
}
