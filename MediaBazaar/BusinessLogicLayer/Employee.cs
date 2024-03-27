using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTOLayer
{
	public class Employee
	{
		private int Id { get; set; }
		private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
		private string Password { get; set; }
		public string PhoneNumber { get; private set; }
		private string BSN { get; set; }
		private DateTime Birthday { get; set; }
		public EmployeeRoleEnum Role { get; private set; }
		public bool IsManager { get; private set; }
		public EmergencyContact EmergencyContact { get; private set; }
		private string Address { get; set; }
		public Contract Contract { get;private set; }

        public Employee(int id, string firstName, string lastName, string email, string password, string bSN, DateTime birthday, EmployeeRoleEnum role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            BSN = bSN;
            Birthday = birthday;
            Role = role;
        }
		public Employee(int id, string firstName, string lastName, string email, string password,string phoneNumber, string bsn, DateTime birthday, int role, bool isManager,string address,
				EmergencyContact emergencyContact,Contract contract)
		{  
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			PhoneNumber= phoneNumber;
			BSN = bsn;
			Birthday = birthday;
			Role = (EmployeeRoleEnum)role;
			IsManager = isManager;
			Address = address;
			Contract = contract;
			EmergencyContact = emergencyContact;
		}

        public void UpdateInformation(string firstName, string lastName, string email, string password, string bSN, DateTime birthday, EmployeeRoleEnum role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            BSN = bSN;
            Birthday = birthday;
            Role = role;
        }

		public void ChangeRole(EmployeeRoleEnum newRole)
		{
			Role = newRole;
		}

		public int GetId()
		{
			return Id;
		}

		public string GetFirstName()
		{
			return FirstName;
		}

        public string GetLastName()
        {
            return LastName;
        }
        public string GetEmail()
        {
            return Email;
        }

		public bool ValidatePassword(string inputPassword)
		{
			return Password == inputPassword;
		}

		public string GetBSN()
		{
			return BSN;
		}

		public string GetEmail()
		{ 
			return Email; 
		}

		public string GetPassword()
		{
			return Password;
		}

		public DateTime GetBirthday()
		{
			return Birthday;
		}

		public string GetAddress()
		{
			return Address;
		}

		public int GetContractID()
		{
			return Contract.Id;
		}
		public int GetEmergencyContactID() 
		{ 
			return EmergencyContact.Id; 
		}
	}
}
