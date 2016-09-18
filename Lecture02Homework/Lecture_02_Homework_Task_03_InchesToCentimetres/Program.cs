using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_02_Homework_Task_03_InchesToCentimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimetres = inches * 2.54;
            Console.Write("centimetres = ");
            Console.Write(centimetres);
        }
    }
}