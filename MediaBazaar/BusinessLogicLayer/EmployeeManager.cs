using System;
using System.Collections.Generic;
using System.Linq;
using DTOLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace MediaBazaar.Classes
{
	public class EmployeeManager
	{
		private EmergencyContactManager _emergencyContactManager;
		private ContractManager _contractManager;
		private List<Employee> employees;

		public EmployeeManager()
		{
			_emergencyContactManager = new EmergencyContactManager();
			_contractManager = new ContractManager();
			employees = new List<Employee>();
		}

		public void AddEmployee(Employee newEmployee)
		{
			if (employees.Any(e => e.GetId() == newEmployee.GetId()))
			{
				throw new Exception("Employee with the same ID already exists.");
			}
			employees.Add(newEmployee);
		}

		public void UpdateEmployee(Employee updatedEmployee)
		{
			var employee = employees.FirstOrDefault(e => e.GetId() == updatedEmployee.GetId());
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
		}

		public void DeleteEmployee(int employeeId)
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

		public List<Employee> GetAllRegularEmployees()
		{
			return employees.Where(e => !e.IsManager).ToList();
		}

		public List<Employee> GetAllManagerEmployees()
		{
			return employees.Where(e => e.IsManager).ToList();
		}

		public List<Employee> GetAllEmployees()
		{
			return employees;
		}

		public List<Employee> SearchEmployees(string searchTerm)
		{
			return employees.Where(e => e.GetFirstName().Contains(searchTerm)).ToList();
		}

		public List<Employee> FilterEmployees(Func<Employee, bool> filter)
		{
			return employees.Where(filter).ToList();
		}

		public Employee TransformDTOToEmployee(EmployeeDTO employeeDTO)
		{
			EmergencyContact emergencyContact = _emergencyContactManager.ReadEmergencyContact(employeeDTO.EmergencyContactId);
			Contract contract = _contractManager.GetContractFromDB(employeeDTO.ActiveContractId);
			if (emergencyContact != null && contract != null)
			{
				Employee employee = new Employee(employeeDTO.Id,
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
