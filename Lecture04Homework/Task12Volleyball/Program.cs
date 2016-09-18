using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] yeartype = new string[] { "leap", "normal"};
            int totalweekends = 48;
            double plays = 0.00;
            string year = Console.ReadLine();
            year = year.ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            if (yeartype.Contains(year) == false || p < 0 || h < 0) { Console.WriteLine("error"); }
            else
            {
                double weekendsinsofia = totalweekends - h;
                double weekendsplayedinsofia = 0.75 * weekendsinsofia;
                plays += weekendsplayedinsofia;
                plays += h;
                double holidayscount = 2.00 / 3.00;
                double holidaysplayed = holidayscount * p;
                plays += holidaysplayed;
                if (year == "leap")
                {
                    plays *= 1.15;
                    Console.WriteLine("{0}", Math.Floor(plays));
                }
                else
                {
                    Console.WriteLine("{0}", Math.Floor(plays));
                }
            }
        }
    }
}
