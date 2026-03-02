namespace Vehicle_To_Purchase
{
    class Vehicle
    {
        public string name {  get; set; }
        public double price {  get; set; }
    }

    class VehicleImplementation
    {
        public double SumOfPrices(List<Vehicle> ls)
        {
            double sum = 0;

            foreach (var i in ls)
            {
                sum += i.price;
            }

            return sum;
        }

        public List<string> GetVehicleList(List<Vehicle> ls)
        {
            List<string> list = new List<string>();
            
            var res = ls.Where(item => item.price > 25000).ToList();

            foreach(var item in res)
            {
                list.Add(item.name);
            }

            return list;
        }

        public double GetMax(List<Vehicle> ls)
        {
            double max = 0;

            var res = ls.OrderBy(item => item.price).ToList();

            res.Reverse();

            max = res[0].price;

            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
