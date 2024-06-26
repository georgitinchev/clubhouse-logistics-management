using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer;

namespace MediaBazaarWebsite.Pages
{
	public class SalesPageModel : PageModel
	{
		public List<Product> Products { get; set; }
		private readonly IProductManager _productManager;
		public SalesPageModel(IProductManager productManager)
		{
			_productManager = productManager;
		}

		public IActionResult OnGet()
		{
			var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
			if (userRole != "SalesRepresentative")
			{
				return RedirectToPage("/Index");
			}
			else
			{
				Products = _productManager.GetAllProducts();
				return Page();
			}
		}
	}
}
