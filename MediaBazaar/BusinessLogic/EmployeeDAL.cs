using System.Data.SqlClient;
using BusinessLogic;
using DataAccess;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BusinessLogic
{
	public class EmployeeDAL : DatabaseOperations
	{
		public List<Employee> GetAllEmployees()
		{
			List<Employee> employees = new List<Employee>();

			using (SqlConnection connection = CreateConnection())
			{
				string query = "SELECT * FROM Employee";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int activeContractId = reader.GetInt32(9);
							int emergencyContactId = reader.GetInt32(10);

							Contract activeContract = GetContractById(activeContractId);
							EmergencyContact emergencyContact = GetEmergencyContactById(emergencyContactId);

							Employee employee = new Employee(
								reader.GetInt32(0),
								reader.GetString(1),
								reader.GetString(2),
								reader.GetString(3),
								reader.GetString(4),
								reader.GetDateTime(5),
								reader.GetString(6),
								reader.GetString(7),
								reader.GetInt64(8),
								activeContract,
								emergencyContact,
								reader.GetBoolean(11),
								(EmployeeRoleEnum)reader.GetInt32(12)
							);

							employees.Add(employee);
						}
					}
				}
			}

			return employees;
		}

		public Employee GetEmployeeById(int id)
		{
			Employee employee = null;

			using (SqlConnection connection = CreateConnection())
			{
				string query = "SELECT * FROM Employee WHERE Id = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							int activeContractId = reader.GetInt32(9);
							int emergencyContactId = reader.GetInt32(10);

							Contract activeContract = GetContractById(activeContractId);
							EmergencyContact emergencyContact = GetEmergencyContactById(emergencyContactId);

							employee = new Employee(
								reader.GetInt32(0),
								reader.GetString(1),
								reader.GetString(2), 
								reader.GetString(3), 
								reader.GetString(4), 
								reader.GetDateTime(5), 
								reader.GetString(6), 
								reader.GetString(7),
								reader.GetInt64(8),
								activeContract,
								emergencyContact,
								reader.GetBoolean(11), 
								(EmployeeRoleEnum)reader.GetInt32(12) 
							);
						}
					}
				}
			}

			return employee;
		}

		public void UpdateEmployee(Employee employee)
		{
			using (SqlConnection connection = CreateConnection())
			{
				string query = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password, Birthday = @Birthday, Address = @Address, PhoneNumber = @PhoneNumber, Bsn = @Bsn, ActiveContractId = @ActiveContractId, EmergencyContactId = @EmergencyContactId, IsManager = @IsManager, Role = @Role WHERE Id = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", employee.Id);
					command.Parameters.AddWithValue("@FirstName", employee.FirstName);
					command.Parameters.AddWithValue("@LastName", employee.LastName);
					command.Parameters.AddWithValue("@Email", employee.Email);
					command.Parameters.AddWithValue("@Password", employee.Password);
					command.Parameters.AddWithValue("@Birthday", employee.Birthday);
					command.Parameters.AddWithValue("@Address", employee.Address);
					command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
					command.Parameters.AddWithValue("@Bsn", employee.Bsn);
					command.Parameters.AddWithValue("@ActiveContractId", employee.ActiveContract.Id);
					command.Parameters.AddWithValue("@EmergencyContactId", employee.EmergencyContact.Id);
					command.Parameters.AddWithValue("@IsManager", employee.IsManager);
					command.Parameters.AddWithValue("@Role", (int)employee.Role);

					command.ExecuteNonQuery();
				}
			}
		}

		public void DeleteEmployee(int id)
		{
			Employee employee = GetEmployeeById(id);
			if (employee != null)
			{
				using (SqlConnection connection = CreateConnection())
				{
					string query = "DELETE FROM Employee WHERE Id = @Id";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Id", id);
						command.ExecuteNonQuery();
					}
				}

				DeleteEmergencyContact(employee.EmergencyContact.Id);
			}
		}

		public void CreateEmployee(Employee employee)
		{
			using (SqlConnection connection = CreateConnection())
			{
				string query = "INSERT INTO Employee (Id, FirstName, LastName, Email, Password, Birthday, Address, PhoneNumber, Bsn, ActiveContractId, EmergencyContactId, IsManager, Role) VALUES (@Id, @FirstName, @LastName, @Email, @Password, @Birthday, @Address, @PhoneNumber, @Bsn, @ActiveContractId, @EmergencyContactId, @IsManager, @Role)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", employee.Id);
					command.Parameters.AddWithValue("@FirstName", employee.FirstName);
					command.Parameters.AddWithValue("@LastName", employee.LastName);
					command.Parameters.AddWithValue("@Email", employee.Email);
					command.Parameters.AddWithValue("@Password", employee.Password);
					command.Parameters.AddWithValue("@Birthday", employee.Birthday);
					command.Parameters.AddWithValue("@Address", employee.Address);
					command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
					command.Parameters.AddWithValue("@Bsn", employee.Bsn);
					command.Parameters.AddWithValue("@ActiveContractId", employee.ActiveContract.Id);
					command.Parameters.AddWithValue("@EmergencyContactId", employee.EmergencyContact.Id);
					command.Parameters.AddWithValue("@IsManager", employee.IsManager);
					command.Parameters.AddWithValue("@Role", (int)employee.Role);

					command.ExecuteNonQuery();
				}
			}
		}

		public Contract GetContractById(int id)
		{
			Contract contract = null;

			using (SqlConnection connection = CreateConnection())
			{
				string query = "SELECT * FROM Contract WHERE Id = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							contract = new Contract(
								reader.GetInt32(0),
								(EmployeeRoleEnum)reader.GetInt32(1),
								(double)reader.GetDecimal(2),
								reader.GetInt32(3),
								reader.GetDateTime(4),
								reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
								reader.GetBoolean(6),
								reader.IsDBNull(7) ? null : reader.GetString(7),
								reader.GetDateTime(8)
							);
						}
					}
				}
			}

			return contract;
		}

		public EmergencyContact GetEmergencyContactById(int id)
		{
			EmergencyContact emergencyContact = null;

			using (SqlConnection connection = CreateConnection())
			{
				string query = "SELECT * FROM EmergencyContact WHERE Id = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							emergencyContact = new EmergencyContact(
								reader.GetInt32(0),
								reader.GetString(1),
								reader.GetString(2),
								reader.GetString(3),
								reader.GetString(4)
							);
						}
					}
				}
			}
			return emergencyContact;
		}
		public void DeleteEmergencyContact(int id)
		{
			using (SqlConnection connection = CreateConnection())
			{
				string query = "DELETE FROM EmergencyContact WHERE Id = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);
					command.ExecuteNonQuery();
				}
			}
		}
	}
}