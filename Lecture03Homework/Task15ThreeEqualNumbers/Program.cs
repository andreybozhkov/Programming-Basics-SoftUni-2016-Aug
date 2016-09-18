using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++) { numbers[i] = double.Parse(Console.ReadLine()); }
            if (numbers[0] == numbers[1] && numbers[0] == numbers[2] && numbers[1] == numbers[2]) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }
    }
}
