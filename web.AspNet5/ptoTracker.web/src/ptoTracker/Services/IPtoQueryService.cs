using System;
using System.Linq;
using System.Threading.Tasks;
using PtoTracker.Models;

namespace PtoTracker.Services
{
	public interface IPtoQueryService : IDisposable
	{
		IQueryable<Pto> GetPtoForUserAsync(string userId);
	}
}