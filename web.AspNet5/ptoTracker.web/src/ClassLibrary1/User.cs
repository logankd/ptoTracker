using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PtoTracker.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(250)]
		public string Name { get; set; }

		public double AcrualHoursPerMonth { get; set; }

		[ForeignKey("Role")]
		public int RoleId { get; set; }
	}
}