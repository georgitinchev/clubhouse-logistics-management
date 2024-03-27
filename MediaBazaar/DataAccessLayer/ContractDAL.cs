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
    public  class ContractDAL :Database
    {
        public void CreateContract(ContractDTO contract)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Contract (Role, HourlyWage, WeeklyHours, StartDate, EndDate, IsActive, TerminationReason, Availability) " +
                    "VALUES (@Role, @HourlyWage, @WeeklyHours, @StartDate, @EndDate, @IsActive, @TerminationReason, @Availability)", connection);

                command.Parameters.AddWithValue("@Role", contract.Role);
                command.Parameters.Add("@HourlyWage", SqlDbType.Decimal).Value = contract.HourlyWage;
                command.Parameters["@HourlyWage"].Precision = 5;
                command.Parameters["@HourlyWage"].Scale = 2;
                command.Parameters.AddWithValue("@WeeklyHours", contract.WeeklyHours);
                command.Parameters.AddWithValue("@StartDate", contract.StartDate);
                command.Parameters.AddWithValue("@EndDate", (object)contract.EndDate ?? DBNull.Value);
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = contract.IsActive;
                command.Parameters.AddWithValue("@TerminationReason", (object)contract.TerminationReason ?? DBNull.Value);
                command.Parameters.AddWithValue("@Availability", contract.Availability);
                
                command.ExecuteNonQuery();
            }
        }

        public ContractDTO ReadContract(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Contract WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ContractDTO
                        {
                            Id = (int)reader["Id"],
                            Role = (int)reader["Role"],
                            HourlyWage = (decimal)reader["HourlyWage"],
                            WeeklyHours = (int)reader["WeeklyHours"],
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : (DateTime)reader["EndDate"],
                            IsActive = (bool)reader["IsActive"],
                            TerminationReason = reader.IsDBNull(reader.GetOrdinal("TerminationReason")) ? null : reader["TerminationReason"].ToString(),
                            Availability = (DateTime)reader["Availability"]
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public void UpdateContract(ContractDTO contract)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "UPDATE Contract SET Role = @Role, HourlyWage = @HourlyWage, WeeklyHours = @WeeklyHours, " +
                    "StartDate = @StartDate, EndDate = @EndDate, IsActive = @IsActive, " +
                    "TerminationReason = @TerminationReason, Availability = @Availability " +
                    "WHERE Id = @Id", connection);

                command.Parameters.AddWithValue("@Id", contract.Id);
                command.Parameters.AddWithValue("@Role", contract.Role);
                command.Parameters.Add("@HourlyWage", SqlDbType.Decimal).Value = contract.HourlyWage;
                command.Parameters["@HourlyWage"].Precision = 5;
                command.Parameters["@HourlyWage"].Scale = 2;
                command.Parameters.AddWithValue("@WeeklyHours", contract.WeeklyHours);
                command.Parameters.AddWithValue("@StartDate", contract.StartDate);
                command.Parameters.AddWithValue("@EndDate", (object)contract.EndDate ?? DBNull.Value);
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = contract.IsActive;
                command.Parameters.AddWithValue("@TerminationReason", (object)contract.TerminationReason ?? DBNull.Value);
                command.Parameters.AddWithValue("@Availability", contract.Availability);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteContract(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Contract WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public List<ContractDTO> GetAllContracts()
        {
            var contracts = new List<ContractDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Contract", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new ContractDTO
                        {
                            Id = (int)reader["Id"],
                            Role = (int)reader["Role"],
                            HourlyWage = (decimal)reader["HourlyWage"],
                            WeeklyHours = (int)reader["WeeklyHours"],
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : (DateTime)reader["EndDate"],
                            IsActive = (bool)reader["IsActive"],
                            TerminationReason = reader.IsDBNull(reader.GetOrdinal("TerminationReason")) ? null : reader["TerminationReason"].ToString(),
                            Availability = (DateTime)reader["Availability"],
                           
                        });
                    }
                }
            }
            return contracts;
        }

    }
}
