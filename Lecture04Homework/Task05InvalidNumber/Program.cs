using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var user_input = int.Parse(Console.ReadLine());
            if (user_input == 0 || (user_input >= 100 && user_input <= 200)) { }
            else { Console.WriteLine("invalid"); }

        }
    }
}
