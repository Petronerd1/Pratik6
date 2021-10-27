using System;
using System.Collections.Generic;

namespace ConsoleApp1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);



            foreach (string flavor in coffee.Keys)
            {
                Console.WriteLine(discountPrice(flavor, coffee[flavor], discount));
            }
        }

        static string discountPrice(string flavor, int price, int discount)
        {
            return $"{flavor}: {price - price * discount / 100}";
        }
    }
}
