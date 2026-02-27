using System;
using System.Collections.Generic;

namespace VehicleRentalSystem
{
    class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public double RatePerDay { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public void Rent()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public virtual void Display()
        {
            Console.WriteLine("Vehicle ID: " + VehicleId);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Rate Per Day: " + RatePerDay);
            Console.WriteLine("Available: " + IsAvailable);
        }
    }

    class Car : Vehicle
    {
        public int SeatingCapacity { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Seating Capacity: " + SeatingCapacity);
        }
    }

    class Bike : Vehicle
    {
        public bool HasGear { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Has Gear: " + HasGear);
        }
    }

    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Load Capacity: " + LoadCapacity + " tons");
        }
    }

    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Customer ID: " + CustomerId);
            Console.WriteLine("Customer Name: " + Name);
        }
    }
    class RentalTransaction
    {
        private Vehicle vehicle;
        private Customer customer;
        private int days;

        public RentalTransaction(Vehicle vehicle, Customer customer, int days)
        {
            this.vehicle = vehicle;
            this.customer = customer;
            this.days = days;
        }

        public double CalculateCharge()
        {
            return days * vehicle.RatePerDay;
        }

        public void RentVehicle()
        {
            if (vehicle.IsAvailable)
            {
                vehicle.Rent();
                Console.WriteLine("Vehicle rented successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not available.");
            }
        }

        public void ReturnVehicle()
        {
            vehicle.Return();
            Console.WriteLine("Vehicle returned successfully.");
        }

        public void DisplayTransaction()
        {
            Console.WriteLine("\n--- Rental Details ---");
            customer.Display();
            vehicle.Display();
            Console.WriteLine("Days Rented: " + days);
            Console.WriteLine("Total Charge: " + CalculateCharge());
        }
    }

}
