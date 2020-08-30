using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class ContactModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[Phone]
		public string Phone { get; set; }

		[Required]
		public string Message { get; set; }
	}
}
