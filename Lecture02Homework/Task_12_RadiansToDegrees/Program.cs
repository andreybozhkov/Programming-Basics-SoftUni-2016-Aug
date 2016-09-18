using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            if (radians < 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                double degree = radians * (180 / Math.PI);
                Console.WriteLine(Math.Round(degree, 0));
            }
        }
    }
}
