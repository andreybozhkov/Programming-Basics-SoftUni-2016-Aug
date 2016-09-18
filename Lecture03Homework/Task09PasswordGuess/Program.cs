using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "s3cr3t!P@ssw0rd";
            var guess = Console.ReadLine();
            if (guess == pass) { Console.WriteLine("Welcome"); }
            else { Console.WriteLine("Wrong password!"); }
        }
    }
}
