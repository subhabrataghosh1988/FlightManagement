using System;
using FlightManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightManagementTest
{
	[TestClass]
	public class AirlineTest
	{
		[TestMethod]
		public void AirLineCreated()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			var airline1 = flight.GetAirline();
			Assert.ReferenceEquals(airline, airline1);
		}
	}
}
