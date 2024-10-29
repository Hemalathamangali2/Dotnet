using System;
using System.Collections.Generic;

namespace InsertionSort
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: Rs.{Price}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product("T-Shirt", 500),
            new Product("Jeans", 1200),
            new Product("Shoes", 2500),
            new Product("Jacket", 3500),
            new Product("Sunglasses", 1500)
        };

            Console.WriteLine("Welcome to Myntra!");

            Console.Write("Enter 'low' to sort by lowest price first or 'high' to sort by highest price first: ");
            string sortOrder = Console.ReadLine();

            if (sortOrder.ToLower() == "low")
            {
                InsertionSort(products, ascending: true);
                Console.WriteLine("\nProducts sorted by price (low to high):");
            }
            else if (sortOrder.ToLower() == "high")
            {
                InsertionSort(products, ascending: false);
                Console.WriteLine("\nProducts sorted by price (high to low):");
            }
            else
            {
                Console.WriteLine("Invalid input! Sorting by default (low to high).");
                InsertionSort(products, ascending: true);
            }

            DisplayProducts(products);
        }

        static void InsertionSort(List<Product> products, bool ascending)
        {
            for (int i = 1; i < products.Count; i++)
            {
                Product key = products[i];
                int j = i - 1;

                while (j >= 0 && (ascending ? products[j].Price > key.Price : products[j].Price < key.Price))
                {
                    products[j + 1] = products[j];
                    j = j - 1;
                }
                products[j + 1] = key;
            }
        }

        static void DisplayProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
