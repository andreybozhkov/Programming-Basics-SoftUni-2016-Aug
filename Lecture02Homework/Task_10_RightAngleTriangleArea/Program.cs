using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_RightAngleTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            if (a <= 0 || h <= 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                double area = a * h / 2;
                Console.WriteLine("Triangle area = " + Math.Round(area, 2));
            }
        }
    }
}
