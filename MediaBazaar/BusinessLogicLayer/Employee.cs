using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediaBazaar.Classes
{
	public class Employee
	{
		private int Id { get; set; }
		private string Name { get; set; }
		private string Email { get; set; }
		private string Password { get; set; }
		private int BSN { get; set; }
		private Date Birthday { get; set; }
		public EmployeeRoleEnum Role { get; private set; }
		public bool IsManager { get; private set; }
		public bool IsActive { get; private set; } = true;

		public Employee(int id, string name, string email, string password, Date birthday, EmployeeRoleEnum role, bool isManager)
		{
			Id = id;
			Name = name;
			Email = email;
			Password = password;
			Birthday = birthday;
			Role = role;
			IsManager = isManager;
		}

		public void UpdateInformation(string newName, string newEmail, string newPassword, Date newBirthday, EmployeeRoleEnum newRole, bool newIsManager)
		{
			Name = newName;
			Email = newEmail;
			Password = newPassword;
			Birthday = newBirthday;
			Role = newRole;
			IsManager = newIsManager;
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

		public string GetName()
		{
			return Name;
		}

		public string GetUsername()
		{
			return Name.Replace(" ", "");
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
