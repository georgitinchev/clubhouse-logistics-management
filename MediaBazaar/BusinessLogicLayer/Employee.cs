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
		private int BSN { get; set; }
		private Date Birthday { get; set; }
		public EmployeeRoleEnum Role { get; private set; }
		public bool IsManager { get; private set; }
		public bool IsActive { get; private set; } = true;

        public Employee(int id, string firstName, string lastName, string email, string password, int bSN, Date birthday, EmployeeRoleEnum role)
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

        public void UpdateInformation(int id, string firstName, string lastName, string email, string password, int bSN, Date birthday, EmployeeRoleEnum role)
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

        public void Deactivate()
		{
			IsActive = false;
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

        public string GetUsername()
		{
			return FirstName + LastName.Replace(" ", "");
		}

		public bool ValidatePassword(string inputPassword)
		{
			return Password == inputPassword;
		}

		public int GetBSN()
		{
			return BSN;
		}
	}
}
