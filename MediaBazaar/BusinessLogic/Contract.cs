using System;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
	public class Contract
	{
		public int Id { get; set; }
		public EmployeeRoleEnum Role { get; set; }
		public double HourlyWage { get; set; }
		public int WeeklyHours { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public bool IsActive { get; set; }
		public string TerminationReason { get; set; }
		public DateTime Availability { get; set; }

		public Contract(int id, EmployeeRoleEnum role, double hourlyWage, int weeklyHours, DateTime startDate, DateTime? endDate, bool isActive, string terminationReason, DateTime availability)
		{
			Id = id;
			Role = role;
			HourlyWage = hourlyWage;
			WeeklyHours = weeklyHours;
			StartDate = startDate;
			EndDate = endDate;
			IsActive = isActive;
			TerminationReason = terminationReason;
			Availability = availability;
		}
	}
}
