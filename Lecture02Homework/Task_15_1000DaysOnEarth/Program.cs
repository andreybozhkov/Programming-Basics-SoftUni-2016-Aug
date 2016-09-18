using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_1000DaysOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            var input_date = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input_date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime new_date = date.AddDays(999);
            Console.WriteLine(new_date.ToString("dd-MM-yyyy"));
        }
    }
}