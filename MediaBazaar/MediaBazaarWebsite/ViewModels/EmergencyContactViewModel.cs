using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.ViewModels
{
	public class EmergencyContactViewModel
	{
		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
