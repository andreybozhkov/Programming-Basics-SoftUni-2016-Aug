using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonus_score = 0.0;
            if (num <= 100) { bonus_score += 5; }
            else if (num > 100 && num <= 1000) { bonus_score = num * 0.20; }
            else if (num > 1000) { bonus_score = num * 0.10; }
            if (num % 2 == 0) bonus_score++;
            if (num % 10 == 5) bonus_score += 2;
            Console.WriteLine(bonus_score);
            Console.WriteLine(num + bonus_score);
        }
    }
}
