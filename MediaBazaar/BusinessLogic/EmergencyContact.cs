using System;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class EmergencyContact
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public EmergencyContact(int id, string firstName, string lastName, string phoneNumber, string email)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;
		}
	}
}
