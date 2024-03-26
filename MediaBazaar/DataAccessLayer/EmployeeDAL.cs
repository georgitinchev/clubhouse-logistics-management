using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace DataAccessLayer
{
    public class EmployeeDAL : Database
    {

        public void CreateEmployee(EmployeeDTO employee)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Employee (FirstName, LastName, Email, Password, Birthday, Address, PhoneNumber, Bsn, Role, ActiveContractId, EmergencyContactId) " +
                    "VALUES (@FirstName, @LastName, @Email, @Password, @Birthday, @Address, @PhoneNumber, @Bsn, @Role, @ActiveContractId, @EmergencyContactId)", connection);

                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Password", employee.Password); 
                command.Parameters.AddWithValue("@Birthday", employee.Birthday);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@Bsn", employee.BSN); 
                command.Parameters.AddWithValue("@Role", employee.Role);
                command.Parameters.AddWithValue("@ActiveContractId", employee.ActiveContractId);
                command.Parameters.AddWithValue("EmergencyContactId", employee.EmergencyContactId);

                command.ExecuteNonQuery();
            }
        }

        public EmployeeDTO GetEmployee(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Employee WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new EmployeeDTO
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Birthday = (DateTime)reader["Birthday"],
                            Address = reader["Address"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            BSN = reader["Bsn"].ToString(),
                            Role = (int)reader["Role"],
                            ActiveContractId = (int)reader["ActiveContractId"],
                            EmergencyContactId = (int)reader["EmergencyContactId"]
                        };
                        
                    }
                }
            }
            return null;
        }
        public void UpdateEmployee(EmployeeDTO employee)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password, " +
                    "Birthday = @Birthday, Address = @Address, PhoneNumber = @PhoneNumber, Bsn = @Bsn, Role = @Role, " +
                    "ActiveContractId = @ActiveContractId, EmergencyContactId = @EmergencyContactId WHERE Id = @Id", connection);

                command.Parameters.AddWithValue("@Id", employee.Id);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Password", employee.Password); 
                command.Parameters.AddWithValue("@Birthday", employee.Birthday);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@Bsn", employee.BSN); 
                command.Parameters.AddWithValue("@Role", employee.Role);
                command.Parameters.AddWithValue("@ActiveContractId", (object)employee.ActiveContractId ?? DBNull.Value);
                command.Parameters.AddWithValue("@EmergencyContactId", (object)employee.EmergencyContactId ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM Employee WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            var employees = new List<EmployeeDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM Employee", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new EmployeeDTO
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(), 
                            Birthday = (DateTime)reader["Birthday"],
                            Address = reader["Address"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            BSN = reader["Bsn"].ToString(),
                            Role = (int)reader["Role"],
                            ActiveContractId = (int)reader["ActiveContractID"],
                            EmergencyContactId = (int)reader["EmergencyContactId"],
                            
                        });
                    }
                }
            }
            return employees;
        }


    }
}
