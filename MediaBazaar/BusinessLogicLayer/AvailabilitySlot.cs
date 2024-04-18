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
        public int Id { get; private set; }
        public int WeekNr { get; private set; }
        public int ContractId { get; private set; }

        public AvailabilitySlot(int  id,int contractid,WorkingTime timeSlot, WeekDayEnum weekDay,int weeknr)
        {   

            Id = id;
            ContractId=contractid;
            TimeSlot = timeSlot;
            WeekDay = weekDay;
            WeekNr = weeknr;
        }
        
    }
}
