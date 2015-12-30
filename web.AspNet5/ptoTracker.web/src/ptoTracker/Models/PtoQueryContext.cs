using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace PtoTracker.Models
{
    public class PtoQueryContext : DbContext
    {
	    public DbSet<Pto> Pto { get; set; }

	    public DbSet<Role> Roles { get; set; }
    }
}
