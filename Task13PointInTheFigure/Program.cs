using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var inside3x = (x >= h - h) && (x <= h * 3);
            var inside3y = (y >= h - h) && (y <= h);
            var inside3 = inside3x && inside3y;
            var inside4x = (x >= h) && (x <= h * 2);
            var inside4y = (y >= h - h) && (y <= h * 4);
            var inside4 = inside4x && inside4y;
            var inside = inside3 || inside4;
            var insideexception1 = (x > h) && (x < h * 2) && (y == h);
            var insideexception2 = (x == h) && (y > h - h) && (y < h);
            var insideexception3 = (x == h * 2) && (y > h - h) && (y < h);
            var exceptions = insideexception1 || insideexception2 || insideexception3;
            var sidex3 = (y == h - h) || (y == h);
            var sidey3 = (x == h - h) || (x == h * 3);
            var sidex4 = (y == h) || (y == h * 4);
            var sidey4 = (x == h) || (x == h * 2);
            var side = sidex3 || sidey3 || sidex4 || sidey4;
            if (inside)
            {
                if (exceptions) { Console.WriteLine("inside"); }
                else if (side) { Console.WriteLine("border"); }
                else { Console.WriteLine("inside"); }
            }
            else if (!inside) { Console.WriteLine("outside"); }
            else { Console.WriteLine("Error!"); }
        }
    }
}
