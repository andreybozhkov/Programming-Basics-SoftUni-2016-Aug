using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine();
            word1 = word1.ToLower();
            var word2 = Console.ReadLine();
            word2 = word2.ToLower();
            if (word1 == word2) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }
    }
}
