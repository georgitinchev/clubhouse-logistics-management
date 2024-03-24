using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class EmployeeWorksheet
	{
		public WorkingTime TimeSlot { get; private set; }
		public WeekDayEnum WeekDay { get; private set; }
		public Employee Employee { get; private set; }
		public int WeekNr { get; private set; }

		public EmployeeWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
		{
			TimeSlot = timeSlot;
			WeekDay = weekDay;
			Employee = employee;
			WeekNr = weekNr;
		}
	}
}
