using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string[] units = new string[] { "m", "mm", "cm", "mi", "in", "km", "ft", "yd" };
            double[] rates = new double[] { 1, 1000, 100, 0.000621371192, 39.3700787, 0.001, 3.2808399, 1.0936133 };
            var unit_from_input = Console.ReadLine();
            var unit_to_input = Console.ReadLine();
            string unit_from = "", unit_to = "";
            int unit_from_index = 0, unit_to_index = 0;
            double result = 0.00;
            if (amount < 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                for (int i = 0; i < units.Length; i++)
                {
                    if (unit_from_input == units[i])
                    {
                        unit_from = unit_from_input;
                        unit_from_index = i;
                    }
                    if (unit_to_input == units[i])
                    {
                        unit_to = unit_to_input;
                        unit_to_index = i;
                    }
                }
                if (unit_from == "" || unit_to == "")
                {
                    Console.WriteLine("Error! Invalid input!");
                }
                else
                {
                    if (unit_from != units[0] && unit_to != units[0])
                    {
                        result = (amount / rates[unit_from_index]) * rates[unit_to_index];
                        Console.WriteLine("{0} {1}", result, unit_to);
                    }
                    else if (unit_from == units[0] && unit_to != units[0])
                    {
                        result = amount * rates[unit_to_index];
                        Console.WriteLine("{0} {1}", result, unit_to);
                    }
                    else if (unit_from != units[0] && unit_to == units[0])
                    {
                        result = amount / rates[unit_from_index];
                        Console.WriteLine("{0} {1}", result, unit_to);
                    }
                    else if (unit_from == units[0] && unit_to == units[0])
                    {
                        Console.WriteLine("{0} {1}", amount, unit_to);
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
