using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DTOLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace MediaBazaar.Classes
{
	public class EmployeeManager
	{
		private EmergencyContactManager _emergencyContactManager;
		private ContractManager _contractManager;

        public EmployeeManager()
        {
            _emergencyContactManager =new EmergencyContactManager();
            _contractManager =new ContractManager();
        }

        public void AddEmployee(List<Employee> employees, Employee newEmployee)
		{
			if (employees.Any(e => e.GetId() == newEmployee.GetId()))
			{
				throw new Exception("Employee with the same ID already exists.");
			}
			employees.Add(newEmployee);
		}

		public void UpdateEmployee(List<Employee> employees, Employee updatedEmployee)
		{
			var employee = employees.FirstOrDefault(e => e.GetId() == updatedEmployee.GetId());
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
			
		}

		public void DeleteEmployee(List<Employee> employees, int employeeId)
		{
			var employee = employees.FirstOrDefault(e => e.GetId() == employeeId);
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
			EmployeeDAL employeeDAL = new EmployeeDAL();
			employeeDAL.DeleteEmployee(employeeId);
			employees.Remove(employee);
		}

		public List<Employee> GetAllRegularEmployees(List<Employee> employees)
		{
			return employees.Where(e => !e.IsManager).ToList();
		}

		public List<Employee> GetAllManagerEmployees(List<Employee> employees)
		{
			return employees.Where(e => e.IsManager).ToList();
		}

		public List<Employee> GetAllEmployees(List<Employee> employees)
		{
			return employees;
		}

		public List<Employee> SearchEmployees(List<Employee> employees, string searchTerm)
		{
			return employees.Where(e => e.GetFirstName().Contains(searchTerm)).ToList();
		}

		public List<Employee> FilterEmployees(List<Employee> employees, Func<Employee, bool> filter)
		{
			return employees.Where(filter).ToList();
		}

		public Employee TransformDTOToEmployee(EmployeeDTO employeeDTO)
		{
            EmergencyContact emergencyContact = _emergencyContactManager.ReadEmergencyContact(employeeDTO.EmergencyContactId);
			Contract contract = _contractManager.GetContractFromDB(employeeDTO.ActiveContractId);
			if (emergencyContact != null && contract != null)

			{ Employee employee = new Employee(employeeDTO.Id,
									  employeeDTO.FirstName,
									  employeeDTO.LastName,
									  employeeDTO.Email,
									  employeeDTO.Password,
									  employeeDTO.BSN,
									  employeeDTO.Birthday,
									  employeeDTO.Role,
									  employeeDTO.IsManager,
									  employeeDTO.Address,
									  emergencyContact,
									  contract);
				return employee;
			}
			return null;

        }

		public Employee GetEmployeeFromDB(string email, string password)
		{
			return null;
		}
	}
}
