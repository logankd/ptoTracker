using System;
using System.Collections.Generic;
using System.Linq;
using PtoTracker.Data;
using PtoTracker.Models;

namespace PtoTracker.Services
{
	/// <summary>
	/// Query PTO objects (read-only following CQRS ideas).
	/// </summary>
    public class PtoQueryService : IPtoQueryService
	{
		private readonly PtoTrackerQueryContext _context;

		public PtoQueryService(PtoTrackerQueryContext context)
		{
			this._context = context;
		}

		public IQueryable<Pto> GetPtoForUser(int userId)
		{
			return new List<Pto>
			{
				new Pto
				{
					Id = 1,
					UserId = 1,
					ApprovedBy = new User {Id = 1, Name = "V"},
					Start = DateTime.Parse("20151223 8:00 AM"),
					End = DateTime.Parse("20151223 5:00 PM")
				}
			}.AsQueryable();
		}
    }
}