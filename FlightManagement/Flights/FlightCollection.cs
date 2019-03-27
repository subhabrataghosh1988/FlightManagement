using FlightManagement.Extentions;
using FlightManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Flights
{
	/// <summary>
	/// This class represents a collection of flights and sorting and filtering of flights
	/// </summary>
    public class FlightCollection
	{
		private List<Flight> _flights;

		#region [ctor]
		public FlightCollection()
		{
			_flights = new List<Flight>();
		}
		#endregion
		/// <summary>
		/// Flight Collection
		/// </summary>
		public List<Flight> Flights {
			get
			{
				return _flights;
			}
			set
			{
				_flights = value;
			}
		}

		#region [Sorting and Filtering]
		public List<Flight> Sort(string PropertyName,bool desc)
		{
		   return Flights.Sort(PropertyName, desc).ToList();
		}

		public List<Flight> Filter(Func<Flight,bool> Predicate)
		{
			return Flights.Filter(Predicate).ToList();
		}
		#endregion

	}
}
