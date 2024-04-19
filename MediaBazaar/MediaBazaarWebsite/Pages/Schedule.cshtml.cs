using DTOLayer;
using MediaBazaar;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
	public class ScheduleModel : PageModel
	{
		private EmployeeManager _employeeManager;
		private EmployeeWorksheetManager _worksheetManager;
		public ScheduleModel(EmployeeManager employeeManager, EmployeeWorksheetManager worksheetManager)
		{
			_employeeManager = employeeManager;
			_worksheetManager = worksheetManager;
		}
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public List<EmployeeWorksheet> Worksheets { get; set; } = new List<EmployeeWorksheet>();
		public void OnGet()
		{
			var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
			if (idClaim != null)
			{
				int id = int.Parse(idClaim.Value);
				var employee = _employeeManager.GetEmployeeById(id);
				if (employee != null)
				{
					FirstName = employee.FirstName;
					LastName = employee.LastName;
					_worksheetManager.GetAllWorksheetsInDB();
					Worksheets = _worksheetManager.assignedWorksheets.Where(w => w.employee == id).ToList();
				}
			}
		}
	}
}
