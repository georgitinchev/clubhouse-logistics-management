using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        public string name { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }
        public DateTime birthday { get; private set; }

        public EmployeeRoleEnum role { get; private set; }

        public ManagerRoleEnum? managerRole { get; private set; }
    }
}
