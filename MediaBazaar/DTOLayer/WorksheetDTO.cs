﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class WorksheetDTO
    {
        public WorkingTime timeSlot;
        public WeekDayEnum weekDay;
        public Employee employee;
        public int weekNr;
    }
}
