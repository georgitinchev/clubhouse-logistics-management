using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
	internal class Contract
	{
		private int Id;
		private EmployeeRoleEnum role;
		private double hourlyWage;
		private int weeklyHours;
		private DateTime startDate;
		private DateTime? endDate;
		private bool isActive;
		private string? terminationReason;
		private DateTime availability;
	}
}
