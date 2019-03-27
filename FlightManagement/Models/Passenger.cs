using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Models
{
	/// <summary>
	/// Passenger
	/// </summary>
	public class Passenger
	{

		private string _pnr;
		private string _firstname;
		private string _lastname;
		private string _emailAddress;
		private string _gender;
		private bool _isSpecialAssistanceRequired;
		private int? _frequentFlyerId;
		private string _flightId;

		public Passenger()
		{

		}

		public Passenger(string pnr,
			             string firstname,
						 string lastname,
						 string emailAddress,
						 string gender,
						 bool isSpecialAssistanceRequired,
						 int? frequentFlyerId,
						 string flightId)
		{
			_pnr = pnr;
			_firstname = firstname;
			_lastname = lastname;
			_emailAddress = emailAddress;
			_gender = gender;
			_isSpecialAssistanceRequired = isSpecialAssistanceRequired;
			_frequentFlyerId = frequentFlyerId;
			_flightId = flightId;
		}


		public string PNR
		{
			get
			{
				return _pnr;
			}
			set
			{
				_pnr = value;
			}
		}

		public string FirstName {
			get
			{
				return _firstname;
			}
			set
			{
				_firstname = value;
			}
		}

		public string LastName
		{
			get
			{
				return _lastname;
			}
			set
			{
				_lastname = value;
			}

		}

		public string EmailAddress
		{
			get
			{
				return _emailAddress;
			}
			set
			{
				_emailAddress = value;
			}

		}

		public string Gender {
			get
			{
				return _gender;
			}
			set
			{
				_gender = value;
			}
		}

		public bool IsSpecialAssistanceRequired {
			get
			{
				return _isSpecialAssistanceRequired;
			}
			set
			{
				_isSpecialAssistanceRequired = value;
			}
		}

		public int? FrequentFlyerId
		{
		   get
		   {
				return _frequentFlyerId;
		   }
		   set
		   {
				_frequentFlyerId = value;
		   }
		}

		public string FlightId {
			get
			{
				return _flightId;
			}
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}
