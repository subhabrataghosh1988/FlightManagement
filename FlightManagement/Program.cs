using FlightManagement.Flights;
using FlightManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement.Extentions;
namespace FlightManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			var airline = new Airline();
			airline.Name = "Air India";
			airline.Code = "AI";

			var flight1 = new Flight(airline);
			flight1.FlightID = "AI 101";
			flight1.FlightStatus = FlightStatus.OnTime;
			flight1.DepartureAirportCode = "CCU";
			flight1.ArrivalAirportCode = "BLR";

			var flight2 = new Flight(airline);
			flight2.FlightID = "AI 102";
			flight2.FlightStatus = FlightStatus.OnTime;
			flight2.DepartureAirportCode = "BLR";
			flight2.ArrivalAirportCode = "CCU";

			var flightCollection = new FlightCollection();
			flightCollection.Flights.Add(flight1);
			flightCollection.Flights.Add(flight2);

			var flightsdesc = flightCollection.Sort("DepartureAirportCode", true);
			var flightsasc = flightCollection.Sort("DepartureAirportCode", false);

			var flightFilter1 = flightCollection.Filter(x => x.DepartureAirportCode=="CCU" && x.ArrivalAirportCode=="BLR");
			var flightFilter2 = flightCollection.Filter(x => x.DepartureAirportCode == "BLR" && x.ArrivalAirportCode=="CCU");
			


		}
	}
}
