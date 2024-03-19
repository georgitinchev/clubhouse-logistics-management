using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
	internal class EmployeeManager
	{
		public List<Employee> GetAllRegularEmployees(List<Employee> employees)
		{
			return employees.FindAll(e => e.Role == RoleEnum.Employee);
		}
	}
}
