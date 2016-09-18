using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shows = new string[] { "premiere", "normal", "discount"};
            double[] prices = new double[] { 12.00, 7.50, 5.00 };
            string currency = "leva";
            var show = Console.ReadLine();
            show = show.ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if (shows.Contains(show) == false || r <= 0 || c <= 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                for (int i = 0; i < shows.Length; i++)
                {
                    if (show == shows[i])
                    {
                        int seats = r * c;
                        double result = seats * prices[i];
                        Console.WriteLine("{0:f2} {1}", result, currency);
                    }
                }
            }
        }
    }
}
