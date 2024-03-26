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
                command.Parameters.AddWithValue("@Password", employee.Password); // Consider hashing this value before storing
                command.Parameters.AddWithValue("@Birthday", employee.Birthday);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@Bsn", employee.BSN); // Added Bsn here
                command.Parameters.AddWithValue("@Role", employee.Role);
                command.Parameters.AddWithValue("@ActiveContractId", (object)employee.ActiveContractId ?? DBNull.Value); // Use DBNull for nullable foreign keys
                command.Parameters.AddWithValue("@EmergencyContactId", (object)employee.EmergencyContactId ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
        }


    }
}
