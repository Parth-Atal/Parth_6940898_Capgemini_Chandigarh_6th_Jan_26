namespace Counpon_Dunia
{
    class InvalidCouponException : Exception
    {
        public InvalidCouponException(string message) : base(message) { }   
    }

    class Product
    {
        public string Name;
        public double Price;
        public string Coupon;

        public Product(string name, double price, string coupon)
        {
            Name = name;
            Price = price;
            Coupon = coupon;
        }
    }


    class Validator
    {
        string message = "Invalid Coupon";
        int discount;

        public string ValidateCoupon(Product p)
        {
            string coupon = p.Coupon;
            if(coupon == null)
            {
                throw new InvalidCouponException(message);
            }
            string[] str = coupon.Split('-');

            if(str.Length != 2)
            {
                throw new InvalidCouponException(message);
            }

            if(str[0].ToLower() != p.Name.ToLower())
            {
                throw new InvalidCouponException(message);
            }

            
            bool isvalid = int.TryParse(str[1], out discount);

            if (!isvalid)
            {
                throw new InvalidCouponException(message);
            }

            if(discount >= 10 && discount <= 25)
            {
                return "Valid Coupon";
            }
            else
            {
                throw new InvalidCouponException(message);
            }

            return "Invalid Coupon";
        }

        public double Netprice(Product p)
        {
            if(ValidateCoupon(p) == "Valid Coupon")
            {
                return p.Price - ((p.Price * discount)/100);
            }

            return 0;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();

            // Test Case 1: Valid Coupon
            try
            {
                Product p1 = new Product("Laptop", 50000, "Laptop-20");

                Console.WriteLine(validator.ValidateCoupon(p1));
                Console.WriteLine("Net Price: " + validator.Netprice(p1));
            }
            catch (InvalidCouponException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // Test Case 2: Invalid Product Name
            try
            {
                Product p2 = new Product("Laptop", 50000, "Mobile-20");

                Console.WriteLine(validator.ValidateCoupon(p2));
                Console.WriteLine("Net Price: " + validator.Netprice(p2));
            }
            catch (InvalidCouponException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // Test Case 3: Invalid Discount Range
            try
            {
                Product p3 = new Product("Laptop", 50000, "Laptop-30");

                Console.WriteLine(validator.ValidateCoupon(p3));
                Console.WriteLine("Net Price: " + validator.Netprice(p3));
            }
            catch (InvalidCouponException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // Test Case 4: Invalid Format
            try
            {
                Product p4 = new Product("Laptop", 50000, "Laptop20");

                Console.WriteLine(validator.ValidateCoupon(p4));
                Console.WriteLine("Net Price: " + validator.Netprice(p4));
            }
            catch (InvalidCouponException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
