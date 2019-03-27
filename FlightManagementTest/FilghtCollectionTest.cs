using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightManagement.Models;
using FlightManagement.Flights;

namespace FlightManagementTest
{
	/// <summary>
	/// Summary description for FilghtCollectionTest
	/// </summary>
	[TestClass]
	public class FilghtCollectionTest
	{
		
		[TestMethod]
		public void FlightCollectionSortTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight1 = new Flight(airline)
			{
				FlightID = "AI 102",
				ArrivalAirportCode = "CCU",
				DepartureAirportCode = "BLR",
				DepartureDateUtc = DateTime.UtcNow,
				ArrivalDateTimeUtc = DateTime.UtcNow.AddMinutes(60),
			};

			var flight2 = new Flight(airline)
			{
				FlightID = "AI 103",
				ArrivalAirportCode = "BLR",
				DepartureAirportCode = "CCU",
				DepartureDateUtc = DateTime.UtcNow,
				ArrivalDateTimeUtc = DateTime.UtcNow.AddMinutes(70),
			};

			var flightCollection = new FlightCollection();
			flightCollection.Flights.Add(flight1);
			flightCollection.Flights.Add(flight2);

			//Sort1
			var flights1 = flightCollection.Sort("DepartureAirportCode", true);
			Assert.AreEqual(flights1[0].DepartureAirportCode, "CCU");
			//Sort2
			var flights2 = flightCollection.Sort("ArrivalAirportCode", true);
			Assert.AreEqual(flights2[0].ArrivalAirportCode, "CCU");
			//Sort3
			var flights3 = flightCollection.Sort("FlightDurationInMinutes", false);
			Assert.AreEqual(flights3[0].FlightID, "AI 102");
		}

		[TestMethod]
		public void FlightCollectionFilterTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight1 = new Flight(airline)
			{
				FlightID = "AI 102",
				ArrivalAirportCode = "CCU",
				DepartureAirportCode = "BLR",
				DepartureDateUtc = DateTime.UtcNow,
				ArrivalDateTimeUtc = DateTime.UtcNow.AddMinutes(60),
			};

			var flight2 = new Flight(airline)
			{
				FlightID = "AI 103",
				ArrivalAirportCode = "BLR",
				DepartureAirportCode = "CCU",
				DepartureDateUtc = DateTime.UtcNow,
				ArrivalDateTimeUtc = DateTime.UtcNow.AddMinutes(70),
			};

			var flightCollection = new FlightCollection();
			flightCollection.Flights.Add(flight1);
			flightCollection.Flights.Add(flight2);

			var flights0 = flightCollection.Filter(t => t.FlightID == "AI 102");
			Assert.AreEqual(flights0[0].FlightID, "AI 102");


			var flights1 = flightCollection.Filter(t => t.DepartureAirportCode == "CCU");
			Assert.AreEqual(flights1[0].DepartureAirportCode, "CCU");

			var flights2 = flightCollection.Filter(t => t.ArrivalAirportCode == "BLR");
			Assert.AreEqual(flights1[0].ArrivalAirportCode, "BLR");

		}

	}
}
