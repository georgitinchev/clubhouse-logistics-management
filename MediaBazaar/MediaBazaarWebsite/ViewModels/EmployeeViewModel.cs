using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.ViewModels
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		public string BSN { get; set; }

		[Required]
		public DateTime Birthday { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string Address { get; set; }
	}
}