
	1. Design a Flight class which represents a flight entity. Flight class can have properties and method to represent the Flight behavior like Flight Number, Origin, Destination. Write a Class, Flight, which can model the flight behavior. Add additional properties and methods which you might think might be required in a Flight class.
	
	2. Design a Flight Collection Class which represent a collection of Flight created in Step1.
		○ Should have a Sort Method by
			§ By Departure Time
			§ By Passenger Count
			§ By Origin
			§ By Destination
			§ It should be easy to add new sorting criteria.
	 
	3. Write an extension method on Flight Collection class, named "Filter", this method should filter the flight based on following criteria. Don't use the where method from System.Linq but take an inspiration from the implementation of "Where" Extension method in the System.Linq.
		a. Filter flight based on an Origin.
		b. Filter flight based on Destinations.
		c. Filter flight based on the duration of the flight.
		d. It should be easy to add a new Filter criteria
(You don't need to write the code for calling based on above criteria, only the filter method Signature and implementation is required.)



