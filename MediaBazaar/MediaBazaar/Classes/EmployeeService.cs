using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
	public class EmployeeService
	{
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
