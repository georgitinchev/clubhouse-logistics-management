using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DTOLayer
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BSN { get; set; }
        public DateTime Birthday { get; set; }
        public int Role { get;  set; }
        public bool IsManager { get; set; } 
        public int ActiveContractId {  get; set; }
        public int EmergencyContactId {  get; set; }
    }
}
