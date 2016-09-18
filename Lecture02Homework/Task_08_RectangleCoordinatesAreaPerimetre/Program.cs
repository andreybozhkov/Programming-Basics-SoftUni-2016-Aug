using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_RectangleCoordinatesAreaPerimetre
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double length = 0.00;
            double height = 0.00;
            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                if (x1 > x2)
                {
                    length = x1 - x2;
                }
                else
                {
                    length = x2 - x1;
                }
                if (y1 > y2)
                {
                    height = y1 - y2;
                }
                else
                {
                    height = y2 - y1;
                }
                double area = length * height;
                double perimetre = 2 * (length + height);
                Console.WriteLine(area);
                Console.WriteLine(perimetre);
            }
        }
    }
}
