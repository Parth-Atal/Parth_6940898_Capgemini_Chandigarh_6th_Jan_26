using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCatalog
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        protected double price;
        protected int stock;

        public void SetPrice(double p)
        {
            price = p;
        }

        public double GetPrice()
        {
            return price;
        }

        public void AddStock(int qty)
        {
            stock += qty;
        }

        public bool ReduceStock(int qty)
        {
            if (stock >= qty)
            {
                stock -= qty;
                return true;
            }
            return false;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {Name}, Price: {price}, Stock: {stock}");
        }
    }

    class Electronics : Product
    {
        public string Brand { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Category: Electronics | Brand: " + Brand);
        }
    }

    class Clothing : Product
    {
        public string Size { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Category: Clothing | Size: " + Size);
        }
    }

    class Books : Product
    {
        public string Author { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Category: Books | Author: " + Author);
        }
    }
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }
    class Cart
    {
        private List<Product> items = new List<Product>();

        public void AddToCart(Product product)
        {
            items.Add(product);
            Console.WriteLine("Product added to cart.");
        }

        public void ViewCart()
        {
            Console.WriteLine("\n--- CART ITEMS ---");
            foreach (var item in items)
            {
                item.Display();
                Console.WriteLine("-----------------");
            }
        }

        public List<Product> GetItems()
        {
            return items;
        }
    }
    class Order
    {
        public void PlaceOrder(Customer customer, Cart cart)
        {
            double total = 0;

            Console.WriteLine("\n--- ORDER DETAILS ---");
            Console.WriteLine("Customer: " + customer.Name);

            foreach (var item in cart.GetItems())
            {
                total += item.GetPrice();
            }

            Console.WriteLine("Total Amount: " + total);
            Console.WriteLine("Order placed successfully.");
        }
    }

}
