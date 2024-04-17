using DTOLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }

  //      public IActionResult OnPost()
  //      {
  //         if(!ModelState.IsValid)
  //          {
  //              return Page();
  //          }

  //         if (employee = null)
  //          {
  //              ModelState.AddModelError(string.Empty, "Invalid login attempt.");
  //              return Page();
  //          }

  //         var isPasswordValid = _employeeManager
		//}
    }
}
