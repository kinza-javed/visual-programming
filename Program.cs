using System;
using System.Collections.Generic;

// Base class: Customer
public class Customer
{
    public string CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

// Derived class: RetailCustomer
public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

// Derived class: CorporateCustomer
public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }
}

// Class: Reservation
public class Reservation
{
    public string ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

// Class: Flight
public class Flight
{
    public string FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }

    public List<Seat> Seats { get; set; } = new List<Seat>(); // Contains Seats
}

// Class: Seat
public class Seat
{
    public string RowNo { get; set; }
    public string SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; } // Available, Reserved, etc.
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Create a flight
        Flight flight = new Flight
        {
            FlightId = "FL123",
            Date = DateTime.Now,
            Origin = "New York",
            Destination = "Los Angeles",
            DepartureTime = DateTime.Now.AddHours(2),
            ArrivalTime = DateTime.Now.AddHours(6),
            SeatingCapacity = 180
        };

        // Create seats for the flight
        flight.Seats.Add(new Seat { RowNo = "1", SeatNo = "A", Price = 150.00m, Status = "Available" });
        flight.Seats.Add(new Seat { RowNo = "1", SeatNo = "B", Price = 150.00m, Status = "Available" });

        // Create a retail customer
        RetailCustomer retailCustomer = new RetailCustomer
        {
            CustomerId = "C123",
            FirstName = "kinza",
            LastName = "javed",
            Street = "123 Main St",
            City = "New York",
            State = "NY",
            ZipCode = "10001",
            Phone = "555-1234",
            Email = "233561@example.com",
            Password = "password123",
            CreditCardType = "Visa",
            CreditCardNo = "4111111111111111"
        };

        // Create a reservation for the customer
        Reservation reservation = new Reservation
        {
            ReservationNo = "R456",
            Date = DateTime.Now
        };

        // Add a seat to the reservation
        reservation.Seats.Add(flight.Seats[0]); // Reserve the first seat

        // Output the details
        Console.WriteLine("Customer: " + retailCustomer.FirstName + " " + retailCustomer.LastName);
        Console.WriteLine("Flight: " + flight.Origin + " to " + flight.Destination);
        Console.WriteLine("Reserved Seat: Row " + reservation.Seats[0].RowNo + ", Seat " + reservation.Seats[0].SeatNo);
    }
}
