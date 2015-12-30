using System;
using System.Linq;
using PtoTracker.Models;

namespace PtoTracker.Services
{
	public interface IPtoQueryService : IDisposable
	{
		IQueryable<Pto> GetPtoForUser(int userId);
	}
}