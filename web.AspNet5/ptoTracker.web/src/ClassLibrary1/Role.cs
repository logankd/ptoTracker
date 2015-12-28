using System.ComponentModel.DataAnnotations;

namespace PtoTracker.Models
{
	public class Role
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
	}
}
