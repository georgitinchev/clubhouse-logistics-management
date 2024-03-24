using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediaBazaar.Classes
{
	public class EmployeeManager
	{
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
			// Update the employee's information here
		}

		public void DeleteEmployee(List<Employee> employees, int employeeId)
		{
			var employee = employees.FirstOrDefault(e => e.GetId() == employeeId);
			if (employee == null)
			{
				throw new Exception("Employee not found.");
			}
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
			return employees.Where(e => e.GetName().Contains(searchTerm)).ToList();
		}

		public List<Employee> FilterEmployees(List<Employee> employees, Func<Employee, bool> filter)
		{
			return employees.Where(filter).ToList();
		}
	}
}
