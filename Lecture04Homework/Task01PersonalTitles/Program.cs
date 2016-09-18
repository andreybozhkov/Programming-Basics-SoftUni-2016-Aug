using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (gender == "m" && age < 16) { Console.WriteLine("Master"); }
            else if (gender == "m" && age >= 16) { Console.WriteLine("Mr."); }
            else if (gender == "f" && age < 16) { Console.WriteLine("Miss"); }
            else if (gender == "f" && age >= 16) { Console.WriteLine("Ms."); }
            else { Console.WriteLine("Error! Invalid input!"); }
        }
    }
}
