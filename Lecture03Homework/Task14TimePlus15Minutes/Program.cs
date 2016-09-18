using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int min_add = 15;
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());
            int total_mins = mins + min_add;
            if (hours > 23 || mins > 59) { Console.WriteLine("Error! Invalid input!"); }
            else
            {
                if (total_mins > 59)
                {
                    if (hours == 23)
                    {
                        hours = 0;
                    }
                    else { hours++; }
                    total_mins -= 60;
                }
                if (total_mins < 10) { Console.WriteLine("{0}:0{1}", hours, total_mins); }
                else { Console.WriteLine("{0}:{1}", hours, total_mins); }
            }
        }
    }
}
