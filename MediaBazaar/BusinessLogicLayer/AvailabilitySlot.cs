using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AvailabilitySlot
    {
        public WorkingTime TimeSlot { get; private set; }
        public WeekDayEnum WeekDay { get; private set; }
        public int ID { get; private set; }

        public AvailabilitySlot(int  id,WorkingTime timeSlot, WeekDayEnum weekDay)
        {
            TimeSlot = timeSlot;
            WeekDay = weekDay;
            ID = id;
        }
        
    }
}
