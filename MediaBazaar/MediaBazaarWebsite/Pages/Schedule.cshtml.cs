using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class ScheduleModel : PageModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public void OnGet()
        {
            var firstNameClaim = User.FindFirst(ClaimTypes.GivenName);
            var lastNameClaim = User.FindFirst(ClaimTypes.Surname);

            if (firstNameClaim != null && lastNameClaim != null)
            {
                FirstName = firstNameClaim.Value;
                LastName = lastNameClaim.Value;
            }
        }
    }
}
