using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private int BSN { get; set; }

        public Employee(int id, string name, string username, string password, int bsn)
        {
            Id = id;
            Name = name;
            Password = password;
            BSN = bsn;
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
