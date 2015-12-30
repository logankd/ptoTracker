using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PtoTracker.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
	{
		public double AcrualHoursPerMonth { get; set; }

		[ForeignKey("Role")]
		public int RoleId { get; set; }
	}
}
