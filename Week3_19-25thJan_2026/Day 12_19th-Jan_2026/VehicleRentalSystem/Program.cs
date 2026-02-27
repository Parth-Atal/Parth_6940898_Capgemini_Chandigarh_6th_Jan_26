using VehicleRentalSystem;

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            VehicleId = 1,
            Model = "Honda City",
            RatePerDay = 2000,
            SeatingCapacity = 5
        };

        Customer customer = new Customer
        {
            CustomerId = 101,
            Name = "Parth"
        };

        RentalTransaction rental = new RentalTransaction(car, customer, 3);

        rental.RentVehicle();
        rental.DisplayTransaction();
        rental.ReturnVehicle();
    }
}
