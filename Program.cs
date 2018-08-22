using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("apples", 22, 23),
                ("oranges", 23, 25),
                ("pears", 21, 23),
            };
            int totalProductsSold = 0;
            double TotalRevenue = 0;
            foreach ((string product, double amount, int quantity) t in transactions)

            {
                totalProductsSold += t.quantity;
                TotalRevenue += t.quantity * t.amount;

            }
                    Console.WriteLine($"Items sold today: {totalProductsSold} with a revenue of {TotalRevenue}");

        }      

    }
}
