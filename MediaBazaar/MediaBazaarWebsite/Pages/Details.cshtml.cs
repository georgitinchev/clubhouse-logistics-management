using BusinessLogicLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MediaBazaarWebsite.ViewModels;

namespace MediaBazaarWebsite.Pages
{

	public class DetailsModel : PageModel
	{
		private EmployeeManager _employeeManager;
		private EmergencyContactManager _emergencyContactManager;

		public DetailsModel(EmployeeManager employeeManager, EmergencyContactManager emergencyContactManager)
		{
			_employeeManager = employeeManager;
			_emergencyContactManager = emergencyContactManager;
		}

		[BindProperty]
		public EmployeeViewModel Employee { get; set; }
		[BindProperty]
		public EmergencyContactViewModel EmergencyContact { get; set; }

		public void OnGet()
		{
			if (Request.Method != "POST" && User.Identity.IsAuthenticated)
			{
				var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
				if (idClaim != null)
				{
					int id = int.Parse(idClaim.Value);
					var employee = _employeeManager.GetEmployeeById(id);
					Employee = new EmployeeViewModel
					{
						Id = employee.EmployeeID,
						FirstName = employee.FirstName,
						LastName = employee.LastName,
						Email = employee.Email,
						BSN = employee.BSN,
						Birthday = employee.Birthday,
						PhoneNumber = employee.PhoneNumber,
						Address = employee.Address
					};
					var emergencyContact = employee.EmergencyContact;
					EmergencyContact = new EmergencyContactViewModel
					{
						FirstName = emergencyContact.FirstName,
						LastName = emergencyContact.LastName,
						PhoneNumber = emergencyContact.PhoneNumber,
						Email = emergencyContact.Email,
					};
				}
			}
		}


		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}


			// Get employees and emergency contacts from the database, update attributes with viewmodel attributes and push to DB
			var employeeToUpdate = _employeeManager.GetEmployeeById(Employee.Id);
			var emergencyContactToUpdate = _emergencyContactManager.ReadEmergencyContact(employeeToUpdate.EmployeeID);
			employeeToUpdate.UpdateInformationWebsite(employeeToUpdate.FirstName, employeeToUpdate.LastName, employeeToUpdate.Email, employeeToUpdate.PhoneNumber, employeeToUpdate.Address);
			emergencyContactToUpdate.UpdateInformationWebsite(emergencyContactToUpdate.FirstName, emergencyContactToUpdate.LastName, emergencyContactToUpdate.PhoneNumber, emergencyContactToUpdate.Email);
			_employeeManager.UpdateEmployee(employeeToUpdate);
			_emergencyContactManager.UpdateEmergencyContactInDB(emergencyContactToUpdate);
			return RedirectToPage("/Details", new { id = employeeToUpdate.EmployeeID });
		}
	}

}