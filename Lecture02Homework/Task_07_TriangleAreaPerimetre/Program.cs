using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_TriangleAreaPerimetre
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            if (r <= 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                double area = Math.PI * r * r;
                double perimetre = 2 * Math.PI * r;
                Console.WriteLine("Area = " + area);
                Console.WriteLine("Perimetre = " + perimetre);
            }
        }
    }
}
