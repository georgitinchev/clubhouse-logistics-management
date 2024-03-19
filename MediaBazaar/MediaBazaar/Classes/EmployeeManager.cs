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
	}
}
