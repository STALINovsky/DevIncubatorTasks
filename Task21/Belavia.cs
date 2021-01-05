using System;
using System.Collections.Generic;
using System.Text;

namespace Task21
{

    /// <summary>
    /// Class to describe flights
    /// </summary>
    class Belavia
    {
        public Belavia(string destination, int aircraftNumber, TypeOfFlight typeOfFlight)
        {
            Destination = destination;
            AircraftNumber = aircraftNumber;
            TypeOfFlight = typeOfFlight;
        }

        public string Destination { get; }
        public int AircraftNumber { get; }
        public TypeOfFlight TypeOfFlight { get; }

        public override string ToString()
        {
            return $"{Destination} {AircraftNumber} - {TypeOfFlight}";
        }
    }
}
