﻿using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using DataAccessLayer;

namespace MediaBazaar
{
	public class EmployeeWorksheetManager
	{
		public List<EmployeeWorksheet> assignedWorksheets = new List<EmployeeWorksheet>();
        private WorksheetDAL worksheetDAL = new WorksheetDAL();


        public void CreateWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, Employee employee, int weekNr)
		{
			EmployeeWorksheet worksheet = new EmployeeWorksheet(timeSlot, weekDay, employee, weekNr);
			assignedWorksheets.Add(worksheet);
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

		public EmployeeWorksheet TransformDTOToWorksheet(WorksheetDTO worksheetDTO)
		{
			
			if (worksheetDTO != null)
			{
                EmployeeManager employeeManager = new EmployeeManager();
                EmployeeWorksheet worksheet = new EmployeeWorksheet(worksheetDTO.Id, (WorkingTime)worksheetDTO.TimeSlot, (WeekDayEnum)worksheetDTO.WeekDay, employeeManager.SearchEmployee(worksheetDTO.EmployeeId), worksheetDTO.WeekNr);

				return worksheet;
			}
			return null;
		}

		public WorksheetDTO TransformWorksheetToDTO( EmployeeWorksheet worksheet)
		{
			WorksheetDTO worksheetDTO = new WorksheetDTO(worksheet.id, (int)worksheet.timeSlot, (int)worksheet.weekDay, worksheet.employee.EmployeeID, worksheet.weekNr);
			return worksheetDTO;
		}

		public void GetAllWorksheetsInDB()
		{
			List<WorksheetDTO>worksheets = worksheetDAL.GetAllWorksheets();
			foreach (WorksheetDTO worksheet in worksheets)
			{
				assignedWorksheets.Add(TransformDTOToWorksheet(worksheet));
			}
		}

		public void UpdateWorksheetInDB(EmployeeWorksheet worksheet)
		{
			if(worksheet != null) 
			worksheetDAL.UpdateWorksheet(TransformWorksheetToDTO(worksheet));
			throw new Exception("Worksheet was null");
		}

		public void DeleteWorksheetInDB(EmployeeWorksheet worksheet)
		{
			if (worksheet != null)
				worksheetDAL.DeleteWorksheet(worksheet.id);
		}

		public void AddWorksheetToDB(EmployeeWorksheet worksheet)
		{
			if(worksheet != null)
				worksheetDAL.CreateWorksheet(TransformWorksheetToDTO(worksheet));
			throw new Exception("Worksheet was null");
		}

	}
}