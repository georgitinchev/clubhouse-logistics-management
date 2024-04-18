using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AvailabilitySlotDAL : Database
    {
        public void CreateContract(AvailabilitySlotDTO availabilitySlot)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Availability (ContractID, TimeSlotID, WeekdayId    ) VALUES (@ContractId, @Timeslot, @Weekday)", connection);
                command.Parameters.AddWithValue("@ContractID", availabilitySlot.ContractID);

                
                command.ExecuteNonQuery();
            }
        }


    }
}
