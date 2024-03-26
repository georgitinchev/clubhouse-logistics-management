using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
    public class ContractDTO
    {
        public int Id;
        public EmployeeRoleEnum role;
        public double hourlyWage;
        public int weeklyHours;
        public DateTime startDate;
        public DateTime? endDate;
        public bool isActive;
        public string? terminationReason;
        public DateTime availability;
    }
}
