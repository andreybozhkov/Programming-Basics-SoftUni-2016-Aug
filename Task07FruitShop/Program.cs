using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[] { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
            string[] weekdays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday" };
            string[] weekend = new string[] { "saturday", "sunday" };
            double[,] prices = new double[2,7]
            {
                { 2.50, 1.20, 0.85, 1.45, 2.70, 5.50, 3.85 },
                { 2.70, 1.25, 0.90, 1.60, 3.00, 5.60, 4.20 },
            };
            var product = Console.ReadLine();
            product = product.ToLower();
            var day = Console.ReadLine();
            day = day.ToLower();
            var quantity = double.Parse(Console.ReadLine());
            int price_index_col = 0;
            double price;
            if (quantity <= 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                if (products == null || day == null)
                {
                    Console.WriteLine("Error! Invalid input!");
                }
                else if (products.Contains(product))
                {
                    for (int p = 0; p < products.Length; p++)
                    {
                        if (product == products[p])
                        {
                            price_index_col = p;
                            break;
                        }
                    }
                    if (weekdays.Contains(day))
                    {
                        price = prices[0, price_index_col];
                        Console.WriteLine(quantity * price);
                    }
                    else if (weekend.Contains(day))
                    {
                        price = prices[1, price_index_col];
                        Console.WriteLine(quantity * price);
                    }
                    else { Console.WriteLine("Error! Invalid input!"); }
                }
                else { Console.WriteLine("Error! Invalid input!"); }
            }
        }
    }
}
