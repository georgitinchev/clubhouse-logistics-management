using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic
{
	public class Employee
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }
		public DateTime Birthday { get; private set; }
		public string Address { get; private set; }
		public string PhoneNumber { get; private set; }
		public long Bsn { get; private set; }
		public Contract ActiveContract { get; private set; }
		public EmergencyContact EmergencyContact { get; private set; }
		public bool IsManager { get; private set; }
		public EmployeeRoleEnum Role { get; private set; }
		public List<EmployeeWorksheet> Worksheets { get; private set; }

		public Employee(int id, string firstName, string lastName, string email, string password, DateTime birthday, string address, string phoneNumber, long bsn, Contract activeContract, EmergencyContact emergencyContact, bool isManager, EmployeeRoleEnum role)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			Birthday = birthday;
			Address = address;
			PhoneNumber = phoneNumber;
			Bsn = bsn;
			ActiveContract = activeContract;
			EmergencyContact = emergencyContact;
			IsManager = isManager;
			Role = role;
			Worksheets = new List<EmployeeWorksheet>();
		}

		public void AddWorksheet(EmployeeWorksheet worksheet)
		{
			Worksheets.Add(worksheet);
		}
	}
}
