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
            availabilityDAL.CreateSlot(TransformSlotToDTO(slot));
            slots.Add(slot);
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

        public AvailabilitySlotDTO TransformSlotToDTO(AvailabilitySlot slot)
        {
            return new AvailabilitySlotDTO(slot.Id, slot.ContractId, (int)slot.TimeSlot, (int)slot.WeekDay, slot.WeekNr);
        }

        public List<AvailabilitySlot> GetContractSlots(int contractid)
        {
            List<AvailabilitySlot> contractslots = new List<AvailabilitySlot>();
            foreach(AvailabilitySlot s in slots)
            {
                if(s.ContractId == contractid)
                    contractslots.Add(s);
            }
            return contractslots;
        }
    }
}
