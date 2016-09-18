using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16Numbers0to100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] firstnumbers = new string[20]
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };
            string[] base_numbers = new string[9] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };
            int base_numbers_index = 0;
            int first_numbers_index = 1;
            int i = 0;
            string[] numbersinwords = new string[101];
            for (int a = 0; a < firstnumbers.Length; a++)
            {
                numbersinwords[i] = firstnumbers[a];
                i++;
            }
            for (; i < numbersinwords.Length;)
            {
                if (first_numbers_index > 9)
                {
                    first_numbers_index = 1;
                    base_numbers_index++;
                }
                if (i % 10 == 0)
                {
                    numbersinwords[i] = base_numbers[base_numbers_index];
                    i++;
                }
                else
                {
                    numbersinwords[i] = base_numbers[base_numbers_index] + " " + firstnumbers[first_numbers_index];
                    first_numbers_index++;
                    i++;
                }
            }
            int[] numbers = new int[101];
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                numbers[counter] = counter;
            }
            if (num > numbers[numbers.Length - 1])
            {
                Console.WriteLine("invalid number");
            }
            else if (num < numbers[0])
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                for (int counter_a = 0; counter_a < numbers.Length; counter_a++)
                {
                    if (num == numbers[counter_a])
                    {
                        Console.WriteLine(numbersinwords[counter_a]);
                    }
                }
            }
        }
    }
}
