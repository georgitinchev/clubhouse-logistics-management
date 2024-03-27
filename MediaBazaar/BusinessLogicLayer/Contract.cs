using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace MediaBazaar.Classes
{
	public class Contract
	{
		private int Id;
		private EmployeeRoleEnum role;
		private decimal hourlyWage;
		private int weeklyHours;
		private DateTime startDate;
		private DateTime? endDate;
		private bool isActive;
		private string? terminationReason;
		private DateTime availability;

        public Contract(int id, EmployeeRoleEnum role, decimal hourlyWage, int weeklyHours, DateTime startDate, DateTime? endDate, bool isActive, string? terminationReason, DateTime availability)
        {
            Id = id;
            this.role = role;
            this.hourlyWage = hourlyWage;
            this.weeklyHours = weeklyHours;
            this.startDate = startDate;
            this.endDate = endDate;
            this.isActive = isActive;
            this.terminationReason = terminationReason;
            this.availability = availability;
        }
    }
}
