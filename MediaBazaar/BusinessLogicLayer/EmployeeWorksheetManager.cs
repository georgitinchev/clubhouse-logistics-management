﻿using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace MediaBazaar
{
	public class EmployeeWorksheetManager
	{
		private List<EmployeeWorksheet> assignedWorksheets = new List<EmployeeWorksheet>();

		public void CreateWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
		{
			//EmployeeWorksheet worksheet = new EmployeeWorksheet(timeSlot, weekDay, employee, weekNr);
			//assignedWorksheets.Add(worksheet);
		}

		public void DeleteWorksheet(EmployeeWorksheet worksheet)
		{
			assignedWorksheets.Remove(worksheet);
		}

		public List<EmployeeWorksheet> ViewEmployeeWorksheets()
		{
			return assignedWorksheets;
		}

		public void AssignWorksheetsToEmployees(List<EmployeeWorksheet> worksheets)
		{
			assignedWorksheets.AddRange(worksheets);
		}

		/*public EmployeeWorksheet TransformWorksheet(WorksheetDTO worksheetDTO)
		{
			EmployeeWorksheet worksheet = new EmployeeWorksheet();
			worksheet.WorkingTime = worksheetDTO.WorkingTime;
			worksheet.WeekDay = worksheetDTO.WeekDay;
			Employee = worksheetDTO.Employee;
			worksheet.WeekNr = worksheetDTO.WeekNr;
			return worksheet;
		}*/
	}
}