using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PtoTracker.Models;

namespace PtoTracker.Services
{
	/// <summary>
	/// Query PTO objects (read-only following CQRS ideas).
	/// </summary>
    public class PtoQueryService : IPtoQueryService
	{
		private readonly PtoQueryContext _context;

		public PtoQueryService(PtoQueryContext context)
		{
			this._context = context;
		}

		public IQueryable<Pto> GetPtoForUserAsync(string userId)
		{
			return DesignData.Pto.AsQueryable();

			// real stuff 
			// TODO: Check Identity and role
			// Authorize controller
			//return this._context.Pto.Where(p => p.ApprovedBy.Id == userId);
		}

		public void Dispose()
		{
			this._context.Dispose();
		}
	}

	public static class DesignData
	{
		public static readonly List<Pto> Pto = new List<Pto>
		{
			new Pto
			{
				Id = 1,
				UserId = 1,
				ApprovedBy = new ApplicationUser {Id = "1", UserName = "V"},
				Start = DateTime.Parse("20151223 8:00 AM"),
				End = DateTime.Parse("20151223 5:00 PM")
			}
		};
	}
}