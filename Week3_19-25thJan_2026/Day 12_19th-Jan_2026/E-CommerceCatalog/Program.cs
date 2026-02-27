using static System.Reflection.Metadata.BlobBuilder;

namespace E_CommerceCatalog
{
    class Program
    {
        static void Main()
        {
            Electronics e1 = new Electronics
            {
                ProductId = 1,
                Name = "Laptop",
                Brand = "Dell"
            };
            e1.SetPrice(60000);
            e1.AddStock(5);

            Books b1 = new Books
            {
                ProductId = 2,
                Name = "Notes from the Underground",
                Author = "Fyodor Dostoevsky"
            };
            b1.SetPrice(500);
            b1.AddStock(10);

            Customer cust = new Customer
            {
                CustomerId = 101,
                Name = "Parth"
            };

            Cart cart = new Cart();
            cart.AddToCart(e1);
            cart.AddToCart(b1);

            cart.ViewCart();

            Order order = new Order();
            order.PlaceOrder(cust, cart);
        }
    }

}
