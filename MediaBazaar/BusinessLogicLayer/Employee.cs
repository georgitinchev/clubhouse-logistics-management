using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTOLayer
{
	public class Employee
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }
		public string PhoneNumber { get; private set; }
		public string BSN { get; private set; }
		public DateTime Birthday { get; private set; }
		public EmployeeRoleEnum Role { get; private set; }
		public bool IsManager { get; private set; }
		public EmergencyContact EmergencyContact { get; private set; }
		public string Address { get; private set; }
		public Contract Contract { get; private set; }

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
		public Employee(int id, string firstName, string lastName, string email, string password, string phoneNumber, string bsn, DateTime birthday, int role, bool isManager, EmergencyContact emergencyContact, string address
				, Contract contract)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			PhoneNumber = phoneNumber;
			BSN = bsn;
			Birthday = birthday;
			Role = (EmployeeRoleEnum)role;
			IsManager = isManager;
			EmergencyContact = emergencyContact;
			Address = address;
			Contract = contract;
		}

<<<<<<< Updated upstream
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
=======
		public void UpdateInformation(int id, string firstName, string lastName, string email, string password, string bSN, DateTime birthday, EmployeeRoleEnum role)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Password = password;
			BSN = bSN;
			Birthday = birthday;
			Role = role;
>>>>>>> Stashed changes
		}
	}
}
