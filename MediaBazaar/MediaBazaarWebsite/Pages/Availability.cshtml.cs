using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
	public class AvailabilityModel : PageModel
	{
		public int ContractId;
		private readonly AvailabilityManager _availabilityManager;
		public AvailabilityModel(EmployeeManager employeeManager)
		{
			//_availabilityManager = employeeManager._contractManager.availabilityManager;
		}

        [HttpPost]
        public IActionResult Submit([FromBody] List<AvailabilitySlotDTO> availabilitySlots)
        {
            Console.WriteLine(availabilitySlots.Count);
            return Page();
        }
    }
}
