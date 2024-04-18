using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using MediaBazaar.Classes;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class Password_ResetModel : PageModel
    {
        private EmployeeManager _employeeManager;
        [BindProperty]
        public string? password { get; private set; }
        [BindProperty]
        public string? password2 {  get; private set; }

        public Password_ResetModel(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        
        public void OnGet()
        { 
        }

        public ActionResult OnPost()
        {
            
            password = Request.Form["password"];
            password2 = Request.Form["password2"];
            PasswordHasher hasher = new PasswordHasher();

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(password2))
            {
                if (password == password2)
                {
                    var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                    if (idClaim != null)
                    {
                       string salt = hasher.GenerateSalt();
                    string hashedpassword = hasher.HashPassword(password, salt);
                    _employeeManager.ChangePassword(hashedpassword, salt,int.Parse(idClaim.Value));
                    

                    }
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
