using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
	public class Contract
	{
		public int Id { get; private set; }
		public EmployeeRoleEnum role { get; private set; }
		public double hourlyWage { get; private set; }
		public int weeklyHours { get; private set; }
		public DateTime startDate { get; private set; }
		public DateTime? endDate { get; private set; }
		public bool isActive { get; private set; }
		public string? terminationReason { get; private set; }
		public DateTime availability { get; private set; }
	}
}
