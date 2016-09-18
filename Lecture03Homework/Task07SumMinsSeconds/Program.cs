using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07SumMinsSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec_sum = 0;
            for (int i = 1; i <= 3; i++) { sec_sum += int.Parse(Console.ReadLine()); }
            var min_sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (sec_sum > 59)
                {
                    min_sum++;
                    sec_sum -= 60;
                }
            }
            if (sec_sum < 10) { Console.WriteLine("{0}:0{1}", min_sum, sec_sum); }
            else { Console.WriteLine("{0}:{1}", min_sum, sec_sum); }
        }
    }
}
