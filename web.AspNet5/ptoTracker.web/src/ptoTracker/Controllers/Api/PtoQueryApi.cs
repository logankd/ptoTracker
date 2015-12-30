using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PtoTracker.Models;
using PtoTracker.Services;

namespace PtoTracker.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Pto")]
    public class PtoQueryApi : Controller
    {
	    private readonly IPtoQueryService _ptoQueryService;

	    public PtoQueryApi(IPtoQueryService ptoQueryService)
	    {
			this._ptoQueryService = ptoQueryService;
	    }

		// GET: ptoQueryApi/GetForUser/5
	    [HttpGet("{id}", Name = "GetForUser")]
	    public async Task<IActionResult> GetForUser([FromRoute] string id)
		{
			if (!this.ModelState.IsValid)
			{
				return this.HttpBadRequest(this.ModelState);
			}

		    var pto = this._ptoQueryService.GetPtoForUserAsync(id)
			    .Take(50)
			    .OrderByDescending(p => p.Start);

		    return this.Ok(pto);
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._ptoQueryService.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}