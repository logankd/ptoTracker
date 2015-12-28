using System.Linq;
using PtoTracker.Models;

namespace PtoTracker.Services
{
	public interface IPtoQueryService
	{
		IQueryable<Pto> GetPtoForUser(int userId);
	}
}