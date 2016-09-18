using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_02_Homework_Task_05_Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            if (age > 1)
            {
                Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
            }
            else
            {
                Console.WriteLine("You are {0} {1}, a {2}-year old person from {3}.", firstName, lastName, age, town);
            }
        }
    }
}
