using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ranges = new double[] { 0, 500, 1000, 10000 };
            string[] cities = new string[3] { "sofia", "varna", "plovdiv" };
            double[,] percentages = new double[3, 4]
            {
                { 0.05, 0.07, 0.08, 0.12 },
                { 0.045, 0.075, 0.10, 0.13 },
                { 0.055, 0.08, 0.12, 0.145 },
            };
            var city = Console.ReadLine();
            city = city.ToLower();
            var sales = double.Parse(Console.ReadLine());
            if (sales <= ranges[0]) { Console.WriteLine("error"); }
            else if (cities.Contains(city) == false) { Console.WriteLine("error"); }
            else
            {
                int percentages_index_row = 0, percentages_index_col = 0;
                for (int c = 0; c < cities.Length; c++)
                {
                    if (city == cities[c])
                    {
                        percentages_index_row = c;
                        break;
                    }
                }
                for (int s = 0; s < ranges.Length; s++)
                {
                    if (s == ranges.Length - 1)
                    {
                        percentages_index_col = ranges.Length - 1; break;
                    }
                    else if (sales > ranges[s] && sales <= ranges[s+1])
                    {
                        percentages_index_col = s; break;
                    }
                }
                Console.WriteLine(sales * percentages[percentages_index_row, percentages_index_col]);
            }
        }
    }
}
