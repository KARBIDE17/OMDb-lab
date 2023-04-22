using Microsoft.AspNetCore.Mvc;
using OMDBLab.Models;
using System.Diagnostics;

namespace OMDBLab.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult MovieSearch() 
		{
			return View();
		}

		[HttpGet]
		public IActionResult MovieSearchForm() 
		{
			return RedirectToAction("MovieSearchResults");
		}

		[HttpPost]
		public IActionResult MovieSearchResults(string Title) 
		{
            return RedirectToAction("MovieResults");
        }

    }
}