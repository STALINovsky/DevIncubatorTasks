using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task21
{
    class Program
    {
        /// <summary>
        /// Factory method, generate list of flights by user input
        /// </summary>
        /// <returns>list of Flights</returns>
        static List<Belavia> ReadFlights()
        {
            Console.WriteLine("Enter count of flights");
            var countOfFlights = int.Parse(Console.ReadLine());
            var flights = new List<Belavia>();

            for (int i = 0; i < countOfFlights; i++)
            {
                var destinationOfFlight = Console.ReadLine();
                var numberOfAircraft = int.Parse(Console.ReadLine());
                var typeOfFlight = Enum.Parse<TypeOfFlight>(Console.ReadLine());

                flights.Add(new Belavia(destinationOfFlight, numberOfAircraft, typeOfFlight));
            }

            return flights;
        }

        /// <summary>
        /// Show list of flights to console
        /// </summary>
        /// <param name="flights"></param>
        static void PrintFlights(IEnumerable<Belavia> flights)
        {
            var flightsStringBuilder = new StringBuilder();
            flightsStringBuilder.AppendJoin('\n', flights);

            Console.WriteLine(flightsStringBuilder.ToString());
        }

        static void Main(string[] args)
        {
            //read list of flights
            var flights = ReadFlights();

            //enter type of flight to find
            Console.WriteLine("Enter type of flight:");
            var targetFlightType = Enum.Parse<TypeOfFlight>(Console.ReadLine());

            //selecting flights
            var targetFlights = flights.Where(flight => flight.TypeOfFlight == targetFlightType);

            //show result
            PrintFlights(targetFlights);
        }
    }
}
