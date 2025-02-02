using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstApp;

public class FlightBookingSystem
{


    public class Flight{

            public string? FlightNumber { get; set; }
            public string? From { get; set; }
            public string? To { get; set; }
            public int TotalSeats { get; set; }
            public int BookedSeats { get; set; }

             // Check seat availability
            public bool AreSeatsAvailable()
            {
                return BookedSeats < TotalSeats;
            }
    }

    // Booking Class
    class Booking
    {
        public string? PassengerName { get; set; }
        public string? FlightNumber { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public DateTime BookingDate { get; set; }
    }


    public static void MainProgram()
    {
        // Initialize Flights
        List<Flight> flights = new List<Flight>()
        {
            new Flight {FlightNumber = "abW12", From = "Delhi", To="Lucknow" , TotalSeats = 5, BookedSeats = 0},
            new Flight {FlightNumber = "AWQ121", From = "Lucknow", To="Delhi" , TotalSeats = 4, BookedSeats = 0},
            new Flight {FlightNumber = "EQR12", From = "Noida", To="Lucknow" , TotalSeats = 7, BookedSeats = 0},
            new Flight {FlightNumber = "GKP27", From = "GKP", To="Noida" , TotalSeats = 9, BookedSeats = 0},

        };

        // List to store bookings
        List<Booking> bookings = new List<Booking>();

        Console.WriteLine("----- Welcome to the Flight Booking System! ---");

        while(true)
        {
        Console.WriteLine(" 1. To Book the flight");
        Console.WriteLine(" 2. To check booking details");
        Console.WriteLine(" 3. To Exit from system");
        Console.Write(" Please enter your input: ");
        
        int option = Convert.ToInt32(Console.ReadLine());


        switch (option)
        {
            case 1:

                Console.WriteLine("Enter the from ");
                String? from = Console.ReadLine();
                Console.WriteLine("Enter the to ");
                String? to = Console.ReadLine();
                
                // find the list of flight available based on From and TO
                var availableFlights = flights.FindAll(f => f.From.Equals(from, StringComparison.OrdinalIgnoreCase) && f.To.Equals(to,StringComparison.OrdinalIgnoreCase));
                
                if(availableFlights.Count == 0)
                {
                Console.WriteLine("No flight available for this from and TO");
                break;
                }

                foreach(var fl in availableFlights)
                {
                    Console.WriteLine($"flightNumber is : {fl.FlightNumber} and availableseats: {fl.TotalSeats - fl.BookedSeats}");

                }
                Console.WriteLine("Pass the flight Number from give list");
                string? flightNumber = Console.ReadLine();

                var SelectedFlight = flights.Find(f => f.FlightNumber.Equals(flightNumber,StringComparison.OrdinalIgnoreCase));

                if(SelectedFlight == null)
                {
                    Console.WriteLine("Invalid flight number");
                    break;
                }
                if(!SelectedFlight.AreSeatsAvailable())
                {
                    Console.WriteLine("No seats in selected flight");
                    break;
                }

                // enter booking details
                Console.WriteLine("Enter the passanger name");
                string passanger = Console.ReadLine();

                //book the seat
                bookings.Add( new Booking 
                {       To = SelectedFlight.To, 
                        From =SelectedFlight.From , 
                        PassengerName = passanger , 
                        FlightNumber = SelectedFlight.FlightNumber , 
                        BookingDate = DateTime.Now
                }) ;

                Console.WriteLine("\n Booking successfull!!");  
                break;             

            case 2:

                if(bookings.Count == 0)
                {
                    Console.WriteLine("there is no booking available");
                    break;
                }
                Console.WriteLine("\n All booking details are:");

                foreach(var booking in bookings)
                {
                    Console.WriteLine("Passanger Name: " + booking.PassengerName);
                    Console.WriteLine("Flight number: " + booking.FlightNumber);
                    Console.WriteLine("From: " + booking.From);
                    Console.WriteLine("TO: " + booking.To);
                    Console.WriteLine("Booking date: " + booking.BookingDate);
                    Console.WriteLine("---------------------------------------");

                }
                break;

            case 3: 

             Console.WriteLine("Thank you for using the Flight Booking System!");
             return;

            default:
            Console.WriteLine("you selected the wrong option");
            break;
        }
      



        }

             
    }


}