using System;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic
{
	public class EmployeeManager
	{
		private EmployeeDAL employeeDAL;
		public EmployeeManager()
		{
			this.employeeDAL = new EmployeeDAL();
		}
		public void AddEmployee(Employee employee)
		{
			// add validate
			employeeDAL.CreateEmployee(employee);
		}

		public void UpdateEmployee(Employee employee)
		{
			// add validate
			employeeDAL.UpdateEmployee(employee);
		}

		public void DeleteEmployee(int id)
		{
			employeeDAL.DeleteEmployee(id);
		}

		public List<Employee> SearchEmployees(string searchTerm)
		{
			//implement search
		}

		public List<Employee> FilterEmployees()
		{
			// implement filter
		}
	}
}
