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
        public void CreateSlot(AvailabilitySlotDTO availabilitySlot)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Availability (ContractID, TimeSlotID, WeekdayId,WeekNumber) VALUES (@ContractId, @TimeslotID, @WeekdayID, @WeekNr)", connection);
                command.Parameters.AddWithValue("@ContractID", availabilitySlot.ContractID);
                command.Parameters.AddWithValue("@TimeSlotID", availabilitySlot.TimeSlotID);
                command.Parameters.AddWithValue("@WeekdayID", availabilitySlot.WeekDayID);
                command.Parameters.AddWithValue("WeekNumber",availabilitySlot.WeekNr);

                
                command.ExecuteNonQuery();
            }
        }

        public List<AvailabilitySlotDTO> GetAvailabilitySlotsPerContract(int contractID) 
        {
            var slots = new List<AvailabilitySlotDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Availability WHERE ContractId= @ContractId", connection);
                command.Parameters.AddWithValue("@ContractId", contractID);

                using ( var reader = command.ExecuteReader()) 
                {
                    while(reader.Read())
                    {
                        slots.Add(new AvailabilitySlotDTO(
                            (int)reader["Id"],
                            (int)reader["ContractId"],
                            (int)reader["WorkingTimeId"],
                            (int)reader["WeekDayId"],
                            (int)reader["WeekNumber"]
                            ));
                    }
                }
            }
            return slots;
        }

        public List<AvailabilitySlotDTO> GetAvailabilitySlots()
        {
            var slots = new List<AvailabilitySlotDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Availability" , connection);
                

                using ( var reader = command.ExecuteReader()) 
                {
                    while(reader.Read())
                    {
                        slots.Add(new AvailabilitySlotDTO(
                            (int)reader["Id"],
                            (int)reader["ContractId"],
                            (int)reader["WorkingTimeId"],
                            (int)reader["WeekDayId"],
                            (int)reader["WeekNumber"]
                            ));
                    }
                }
            }
            return slots;
        }

        public void DeleteAvailabilitySlots(int Id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Availability WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();

            }

        }
    }
}
