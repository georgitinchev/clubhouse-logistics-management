﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    internal class EmployeeWorksheet
    {
        private WorkingTime timeSlot;
        private WeekDayEnum weekDay;
        private Employee employee;
        private int weekNr;

        public EmployeeWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
        {
			this.timeSlot = timeSlot;
			this.weekDay = weekDay;
			this.employee = employee;
			this.weekNr = weekNr;
		}
    }
}
