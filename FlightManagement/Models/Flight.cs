using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Models
{
	/// <summary>
	/// This enum represents the flight status
	/// </summary>
	public enum FlightStatus { Scheduled, OnTime, Delayed, Cancelled}
	/// <summary>
	/// Flight model
	/// </summary>
	public class Flight
	{
		private Airline _airline;
		private List<Passenger> _passengers;
		
		public Flight(Airline airline)
		{
			_airline = airline;
			_passengers = new List<Passenger>();
		}

		public string FlightID { get; set; }

		public DateTime DepartureDateLocal { get; set; }

		public DateTime DepartureDateUtc { get; set; }
		
		public DateTime ArrivalDateTime { get; set; }

		public DateTime ArrivalDateTimeUtc { get; set; }

		public double FlightDurationInMinutes
		{
			get
			{
				return (ArrivalDateTimeUtc - DepartureDateUtc).TotalMinutes;
			}
		}

		public int PassengerCount
		{
			get
			{
				return _passengers.Count;
			}
		}

		public string DepartureAirportCode { get; set; }

		public string ArrivalAirportCode { get; set; }

		public FlightStatus FlightStatus { get; set; }

		public Airline GetAirline()
		{
			return _airline;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public List<Passenger> GetAllPassengers()
		{
			return _passengers;
		}
		/// <summary>
		/// Add passenger to a flight
		/// </summary>
		/// <param name="PNR"></param>
		/// <param name="FirstName"></param>
		/// <param name="LastName"></param>
		/// <param name="EmailAddress"></param>
		/// <param name="Gender"></param>
		/// <param name="IsSpecialAssistanceRequired"></param>
		/// <param name="FrequentFlyerId"></param>
		public void AddPassenger(string PNR, 
			                     string FirstName,
								 string LastName,
								 string EmailAddress,
								 string Gender,
								 bool IsSpecialAssistanceRequired,
								 int? FrequentFlyerId)
		{
			var _passenger = new Passenger(PNR, FirstName, LastName, EmailAddress, Gender, IsSpecialAssistanceRequired, FrequentFlyerId, this.FlightID);
			_passengers.Add(_passenger);
		}
		/// <summary>
		/// Remove a passenger from flight
		/// </summary>
		/// <param name="PNR"></param>
		/// <returns></returns>
		public bool RemovePassenger(string PNR)
		{
			var passenger = _passengers.FirstOrDefault(t => t.PNR == PNR);
			if(passenger!=null)
			{
				return _passengers.Remove(passenger);
			}
			return true;
		}
		/// <summary>
		/// Search Passenger
		/// </summary>
		/// <param name="PNR">Search passenger</param>
		/// <returns></returns>
		public Passenger SearchPassenger(string PNR)
		{
			var passenger = _passengers.FirstOrDefault(t => t.PNR == PNR);
			if (passenger == null)
			{
				throw new ArgumentException("Passenger not found");
			}
			return passenger;

		}
	}
}
