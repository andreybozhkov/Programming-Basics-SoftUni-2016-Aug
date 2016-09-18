using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[5] { "coffee", "water", "beer", "sweets", "peanuts" };
            string[] cities = new string[3] { "sofia", "plovdiv", "varna" };
            double[,] prices = new double[3, 5]
            {
                { 0.50, 0.80, 1.20, 1.45, 1.60 },
                { 0.40, 0.70, 1.15, 1.30, 1.50 },
                { 0.45, 0.70, 1.10, 1.35, 1.55 },
            };
            var product = Console.ReadLine();
            product = product.ToLower();
            var city = Console.ReadLine();
            city = city.ToLower();
            var quantity = double.Parse(Console.ReadLine());
            int price_index_row = 0, price_index_col = 0;
            double price;
            if (quantity < 0)
            {
                Console.WriteLine("Error! Invalid input!");
            }
            else
            {
                if (products == null || cities == null)
                {
                    Console.WriteLine("Error! Invalid input!");
                }
                else if (products.Contains(product) && cities.Contains(city))
                {
                    for (int p = 0; p < products.Length; p++)
                    {
                        if (product == products[p])
                        {
                            price_index_col = p;
                            break;
                        }
                    }
                    for (int c = 0; c < cities.Length; c++)
                    {
                        if (city == cities[c])
                        {
                            price_index_row = c;
                            break;
                        }
                    }
                    price = prices[price_index_row, price_index_col];
                    Console.WriteLine(quantity * price);
                }
                else { Console.WriteLine("Error! Invalid input!"); }
            }
        }
    }
}
