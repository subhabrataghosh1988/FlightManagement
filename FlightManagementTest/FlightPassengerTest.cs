using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightManagement.Models;

namespace FlightManagementTest
{
	/// <summary>
	/// Summary description for FlightPassengerTest
	/// </summary>
	[TestClass]
	public class FlightPassengerTest
	{
		
		[TestMethod]
		public void AddPassengerTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			Assert.AreEqual(flight.PassengerCount, 1);
		}'


		[TestMethod]
		public void GetAllPassengerTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN1", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			flight.AddPassenger("AIPQN2", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			flight.AddPassenger("AIPQN3", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			Assert.AreEqual(flight.GetAllPassengers().Count,3);
		}

		[TestMethod]
		public void RemovePassengerCorrectPRNTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			flight.RemovePassenger("AIPQN");
			Assert.AreEqual(flight.PassengerCount, 0);
		}

		[TestMethod]
		public void RemovePassengerInCorrectPRNTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			flight.RemovePassenger("AIPQNX");
			Assert.AreEqual(flight.PassengerCount, 1);
		}


		[TestMethod]
		public void SearchPassengerCorrectPRNTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			var passenger=flight.SearchPassenger("AIPQN");
			Assert.AreEqual(passenger.PNR, "AIPQN");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException),"Passenger not found")]
		public void SearchPassengerInCorrectPRNTest()
		{
			var airline = new Airline() { Name = "Air India", Code = "AI" };
			var flight = new Flight(airline);
			flight.AddPassenger("AIPQN", "Subha", "Ghosh", "subhabrata.ghosh@gmail.com", "A", true, null);
			flight.SearchPassenger("AIPQNs");
		}
	}
}
