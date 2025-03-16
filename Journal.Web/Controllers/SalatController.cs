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

        // GET: Products/Create
		public IActionResult Create()
		 { return View(); }

        // POST: Products/Create
		[HttpPost] [ValidateAntiForgeryToken] 
		public async Task<IActionResult> Create([Bind("Id,Din,Fajr,Zohr,Asr,Maghreb,Isha,Remarks")] SalatModel salat)
		{ if (ModelState.IsValid) 
			{
				//_context.Add(product); 
				 await _salatService.AddAsync(salat);
							            
				return RedirectToAction(nameof(Index));
			} 
			return View(salat);
		}

    }
}
