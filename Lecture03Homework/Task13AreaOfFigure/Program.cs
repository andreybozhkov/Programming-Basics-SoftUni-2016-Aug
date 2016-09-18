using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13AreaOfFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side*=side, 3));
            }
            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side1 * side2, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI) * (radius *= radius), 3));
            }
            else if (figure == "triangle")
            {
                var base_side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((base_side * height) / 2.000, 3));
            }
            else { Console.WriteLine("Error! Invalid input!"); }
        }
    }
}
