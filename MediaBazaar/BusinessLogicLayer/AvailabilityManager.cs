using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using DataAccessLayer;
using MediaBazaar.Classes;

namespace BusinessLogicLayer
{
    public class AvailabilityManager
    {
        public AvailabilitySlotDAL availabilityDAL { get; private set;}
        public List<AvailabilitySlot> slots { get; private set;}
       
        public AvailabilityManager()
        {
            availabilityDAL = new AvailabilitySlotDAL();
            slots = new List<AvailabilitySlot>();
            GetAllAvailabilitySlots();
        }

        public void AddAvailabilitySlot( AvailabilitySlot slot)
        {

        }

        public void GetAllAvailabilitySlots()
        {
            slots.Clear();
            foreach(AvailabilitySlotDTO dto in availabilityDAL.GetAvailabilitySlots())
            {
                slots.Add(TransformDTOToSlot(dto));
            }
        }

        public AvailabilitySlot TransformDTOToSlot(AvailabilitySlotDTO dto)
        {
            return new AvailabilitySlot(dto.Id, dto.ContractID,(WorkingTime)dto.TimeSlotID, (WeekDayEnum)dto.WeekDayID,dto.WeekNr );
        }
    }
}
