using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class EmployeeWorksheetManager
    {
        private List<EmployeeWorksheet> assignedWorksheets = new List<EmployeeWorksheet>();
        private List<Employee> managesEmployees = new List<Employee>();

        public void createWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
        {
			EmployeeWorksheet worksheet = new EmployeeWorksheet(timeSlot, weekDay, employee, weekNr);
			assignedWorksheets.Add(worksheet);
		}
        public void deleteWorksheet(EmployeeWorksheet worksheet)
        {
            assignedWorksheets.Remove(worksheet);
        }
        public void viewEmployeeWorksheets()
        {
			foreach (EmployeeWorksheet worksheet in assignedWorksheets)
            {
				Console.WriteLine(worksheet);
			}
		}
        public void assignWorksheetsToEmployees(Employee employee)
        {
			managesEmployees.Add(employee);
		}
    }
}
