using Journal.Web.Models.Salat;
using Journal.Web.Services.Salat;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Web.Controllers
{
	public class SalatController : Controller
	{

		private readonly SalatService _salatService;

		public SalatController(SalatService salatService)
		{
			_salatService = salatService;
		}
		public async Task<IActionResult> Index()
		{
		  List<SalatModel> lstsalat = await _salatService.GetAll();

			return View(lstsalat);
		}



	}
}
