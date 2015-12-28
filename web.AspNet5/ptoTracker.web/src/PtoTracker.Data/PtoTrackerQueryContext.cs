using System.Data.Entity;
using PtoTracker.Models;

namespace PtoTracker.Data
{
    public class PtoTrackerQueryContext : DbContext
    {
	    public DbSet<Pto> Pto { get; set; }

	    public PtoTrackerQueryContext()
	    {
		    
	    }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Configurations.Add(new AspNetRoleMap());
		}
	}
}
