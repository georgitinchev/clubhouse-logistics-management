using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class AvailabilitySlotDTO
    {
        public int ContractID;
        public int Id;
        public int TimeSlotID;
        public int WeekDayID;
        public int WeekNr;

        public AvailabilitySlotDTO( int slotID,int contractID ,int timeSlotID, int weekDayID, int weekNr)
        {
            ContractID = contractID;
            Id = slotID;
            TimeSlotID = timeSlotID;
            WeekDayID = weekDayID;
            WeekNr = weekNr;
        }
    }
}
