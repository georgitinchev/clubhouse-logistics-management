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
		private EmployeeDAL employeeDAL;
		public List<Employee> employees { get; private set; }

		public EmployeeManager()
		{
			_emergencyContactManager = new EmergencyContactManager();
			_contractManager = new ContractManager();
			employees = new List<Employee>();
			employeeDAL = new EmployeeDAL();

		}

		public void AddEmployee(Employee newEmployee)
		{
			if (employees.Any(e => e.Id == newEmployee.Id))
			{
				throw new Exception("Employee already exists.");
			}
			employees.Add(newEmployee);
			//employeeDAL.CreateEmployee(TransformEmployeeToDTO(newEmployee));
		}

		public Employee SearchEmployee(int id)
		{
			foreach(Employee emp in employees)
			{
				if (emp.Id == id)
				{
					return emp;
				}
			}
			return null;
		}

		public void UpdateEmployee(Employee updatedEmployee)
		{
			var employee = employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
            employeeDAL.UpdateEmployee(TransformEmployeeToDTO(updatedEmployee));
        }

		public void DeleteEmployee(int employeeId)
		{
			var employee = employees.FirstOrDefault(e => e.Id == employeeId);
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
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
			return employees.Where(e => e.FirstName.Contains(searchTerm)).ToList();
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
									  employeeDTO.PhoneNumber,
									  employeeDTO.BSN,
									  employeeDTO.Birthday,
									  employeeDTO.Role,
									  employeeDTO.IsManager,
									  emergencyContact,
									  employeeDTO.Address,
									  contract);
				return employee;
			}
			throw new InvalidOperationException("Emergency contact or contract is null.");
		}


		public EmployeeDTO TransformEmployeeToDTO(Employee employee)
		{
			EmployeeDTO employeeDTO = new EmployeeDTO(
				employee.Id,
				employee.FirstName,
				employee.LastName,
				employee.Email,
				employee.Password,
				employee.Address,
				employee.PhoneNumber,
				employee.BSN,
				employee.Birthday,
				(int)employee.Role,
				employee.IsManager,
				employee.Contract.Id,
				employee.EmergencyContact.Id
				); ;
			return employeeDTO;
		}

		public void GetEmployeesFromDB(string email, string password)
		{
			List<EmployeeDTO> listOfEmployeeDTO = employeeDAL.GetAllEmployees();
			foreach ( EmployeeDTO dto in listOfEmployeeDTO)
			{
				employees.Add(TransformDTOToEmployee(dto));
			}
		}

		
	}
}
