using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = double.Parse(Console.ReadLine());
            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
