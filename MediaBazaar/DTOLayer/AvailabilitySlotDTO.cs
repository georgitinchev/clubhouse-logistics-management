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
        public int SlotID;
        public int TimeSlotID;
        public int WeekDayID;

        public AvailabilitySlotDTO(int contractID, int slotID, int timeSlotID, int weekDayID)
        {
            ContractID = contractID;
            SlotID = slotID;
            TimeSlotID = timeSlotID;
            WeekDayID = weekDayID;
        }
    }
}
