using System;
using System.Collections.Generic;

namespace ProductSales;

struct Product
{
    public string ProductID;
    public int TotalSalesAmount;
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        string input;

        // Read multiple lines until empty line
        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split('-');
            string id = parts[0];
            int amount = int.Parse(parts[1]);

            bool found = false;

            // Check if product already exists
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductID == id)
                {
                    // Keep the highest sales amount
                    if (amount > products[i].TotalSalesAmount)
                    {
                        products[i] = new Product
                        {
                            ProductID = id,
                            TotalSalesAmount = amount
                        };
                    }
                    found = true;
                    break;
                }
            }

            // If not found, add new product
            if (!found)
            {
                Product p = new Product();
                p.ProductID = id;
                p.TotalSalesAmount = amount;
                products.Add(p);
            }
        }

        // Sort in decreasing order of TotalSalesAmount (Bubble Sort)
        for (int i = 0; i < products.Count - 1; i++)
        {
            for (int j = 0; j < products.Count - i - 1; j++)
            {
                if (products[j].TotalSalesAmount < products[j + 1].TotalSalesAmount)
                {
                    Product temp = products[j];
                    products[j] = products[j + 1];
                    products[j + 1] = temp;
                }
            }
        }

        // Print results
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i].ProductID + "-" + products[i].TotalSalesAmount);
        }
    }
}