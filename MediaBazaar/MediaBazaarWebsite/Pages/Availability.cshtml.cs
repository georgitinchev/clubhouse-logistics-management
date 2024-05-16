using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
	public class AvailabilityModel : PageModel
	{
		private readonly AvailabilityManager _availabilityManager;
		public AvailabilityModel(EmployeeManager employeeManager)
		{
			//_availabilityManager = employeeManager._contractManager.availabilityManager;
		}

		[HttpPost]
		public IActionResult OnPostSubmit([FromBody] List<AvailabilitySlotDTO> slots)
		{
			_availabilityManager.AddAvailabilitySlots(slots);
			return new OkResult();
		}
	}
}
