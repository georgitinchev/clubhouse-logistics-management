using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using MediaBazaar.Classes;

namespace MediaBazaarWebsite.Pages
{
    public class Password_ReserModel : PageModel
    {
        private EmployeeManager _employeeManager;
        private int _employeeID;
        
        public void OnGet(EmployeeManager employeeManager, int employeeID)
        {
            _employeeID = employeeID;
            _employeeManager = employeeManager;
            
        }

        public ActionResult OnPost()
        {
            string password = Request.Form["password"];
            string password2 = Request.Form["password2"];
            PasswordHasher hasher = new PasswordHasher();

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(password2))
            {
                if (password == password2)
                {
                    string salt = hasher.GenerateSalt();
                    string hashedpassword = hasher.HashPassword(password, salt);
                    // _employeeManager.ChangePassword(hashedpassword,salt,_employeeID);
                    return RedirectToPage("/");
                }
                else
                {
                    TempData["ErrorMessage"] = "Passwords do not match.";
                    return Page();
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Password can't be empty";
                return Page();
            }
        }
    }
}
