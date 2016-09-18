using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_02_Homework_Task_06_Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            if (b1 <= 0 || b2 <= 0 || h <= 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                double area = (b1 + b2) * h / 2;
                Console.WriteLine("Trapezoid area = " + area);
            }
        }
    }
}
