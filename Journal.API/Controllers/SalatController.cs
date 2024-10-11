using Journal.Application.Services.Salats;
using Microsoft.AspNetCore.Mvc;
using Journal.Domain.Models;

namespace Journal.API.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class SalatController : Controller
	{

		private readonly ISalatService _salatService;

		public SalatController(ISalatService salatService)
		{
			_salatService = salatService;
		}

		//Get: api/<SalatController>
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Salat>>> GetActionResultAsync()
		{
			var salat = await _salatService.GetAllAsync();
			return Ok(salat);
		}
		
	}
}
