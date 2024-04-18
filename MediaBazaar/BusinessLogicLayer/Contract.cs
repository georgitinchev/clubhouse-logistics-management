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
		public int Id { get; private set; }
		public EmployeeRoleEnum role {  get; private set; }
		public decimal hourlyWage { get; private set; }
		public int weeklyHours { get; private set; }
		public DateTime startDate { get; private set; }
		public DateTime? endDate { get; private set; }
		public bool isActive { get; private set; }
		public string? terminationReason { get; private set; }
		public DateTime? availability {  get; private set; }
        public List<Tuple<WorkingTime, WeekDayEnum>> Availability { get; private set; }

        public Contract(int id, EmployeeRoleEnum role, decimal hourlyWage, int weeklyHours, DateTime startDate, DateTime? endDate, bool isActive, string? terminationReason, DateTime? availability)
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

        public void UpdateTerminationReason(string terminationReason)
        {
            this.terminationReason = terminationReason;
        }
        public void UpdateEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public void UpdateIsActive(bool isActive)
        {
            this.isActive = isActive;
        }
    }
}
