using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        //executing the main code
        static void Main(string[] args)
        {
            // creating a list that will contain a string, decimal, and int
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("apples", 22.50, 23),
                ("oranges", 23.50, 25),
                ("pears", 11.50, 23),
                ("bananas", 31.50, 23),
                ("peaches", 24.50, 23),
            };

            // creating an empty int and decimal
            int totalProductsSold = 0;
            double TotalRevenue = 0;

            // looping through the transactions
            foreach ((string product, double amount, int quantity) t in transactions)

            {
                // total products sold = quantity added together
                totalProductsSold += t.quantity;
                // total revenue = total quantity times amount
                TotalRevenue += t.quantity * t.amount;

            }
                    Console.WriteLine($"Items sold today: {totalProductsSold} with a revenue of {TotalRevenue}");

        }      

    }
}
