using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var xinside = (x >= x1) && (x <= x2);
            var yinside = (y >= y1) && (y <= y2);
            var inside = xinside && yinside;
            var xside = (y == y1) || (y == y2);
            var yside = (x == x1) || (x == x2);
            var side = xside || yside;
            if (inside)
            {
                if (side) { Console.WriteLine("Border"); }
                else { Console.WriteLine("Inside / Outside"); }
            }
            else if (!inside) { Console.WriteLine("Inside / Outside"); }
            else { Console.WriteLine("Error!"); }
        }
    }
}
