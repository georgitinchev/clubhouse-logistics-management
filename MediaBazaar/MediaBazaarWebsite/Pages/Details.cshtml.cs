using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
	public class DetailsModel : PageModel
	{
		private readonly EmployeeManager? _employeeManager;

		[BindProperty]
		public Employee employee { get; set; }

		public DetailsModel(EmployeeManager employeeManager)
		{
			_employeeManager = employeeManager;
		}

		public void OnGet()
		{
			// Fetch the details of the current user
			employee = _employeeManager?.GetEmployeeByName(User.Identity.Name);
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			// Update the user
			_employeeManager?.UpdateEmployee(employee);
			return RedirectToPage("./Details");
		}
	}
}
