using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace MediaBazaar
{
	public class EmployeeWorksheet
	{
		private WorkingTime timeSlot;
		private WeekDayEnum weekDay;
		private Employee employee;
		private int weekNr;
		private int id;

		public EmployeeWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr,int Id)
		{
			this.timeSlot = timeSlot;
			this.weekDay = weekDay;
			this.employee = employee;
			this.weekNr = weekNr;
			this.id = Id;
		}

		public EmployeeWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
		{
			this.timeSlot = timeSlot;
			this.weekDay = weekDay;
			this.employee = employee;
			this.weekNr = weekNr;
		}

		
	}
}
