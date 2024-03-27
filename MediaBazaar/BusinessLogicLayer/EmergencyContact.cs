using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DTOLayer;

namespace MediaBazaar.Classes
{
    public class EmergencyContact
    {
        private string FirstName;
        private string LastName;
        private string PhoneNumber;
        private string Email;
        private int Id;

        public EmergencyContact(int id,string firstName, string lastName, string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            
        }

        
    }
}
