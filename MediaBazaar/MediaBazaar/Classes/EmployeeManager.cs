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
		public List<Employee> GetAllRegularEmployees(List<Employee> employees)
		{
			List<Employee> regularEmployees = new List<Employee>();
			foreach (Employee employee in employees)
			{
				if (!employee.IsManager)
				{
					regularEmployees.Add(employee);
				}
			}
			return regularEmployees;
		}

		public List<Employee> GetAllManagerEmployees(List<Employee> employees)
		{
			List<Employee> managerEmployees = new List<Employee>();
			foreach (Employee employee in employees)
			{
				if (employee.IsManager)
				{
					managerEmployees.Add(employee);
				}
			}
			return managerEmployees;
		}

		public List<Employee> GetAllEmployees(List<Employee> employees)
		{
			return employees;
		}

		public void AddEmployee(List<Employee> employees, int id, string name, string email, string password, Date birthday, EmployeeRoleEnum role, ManagerRoleEnum managerRole)
		{
			employees.Add(new Employee(id, name, email, password, birthday, role, managerRole, false));
		}


		public void DeactivateEmployee(List<Employee> employees, int employeeId)
		{
			foreach (Employee employee in employees)
			{
				if (employee.GetId() == employeeId)
				{
					employee.Deactivate();
					break;
				}
			}
		}

		public void DeleteEmployee(List<Employee> employees, int employeeId)
		{
			employees.RemoveAll(e => e.GetId() == employeeId);
		}

		public void ChangeEmployeeRole(List<Employee> employees, int employeeId, EmployeeRoleEnum newRole)
		{
			foreach (Employee employee in employees)
			{
				if (employee.GetId() == employeeId)
				{
					employee.ChangeRole(newRole);
					break;
				}
			}
		}
	}
}
