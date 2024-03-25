using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediaBazaar.Classes
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int BSN { get; set; }
        public Date Birthday { get; set; }
        public EmployeeRoleEnum Role { get; private set; }
        public bool IsActive { get; private set; } = true;
    }
}
