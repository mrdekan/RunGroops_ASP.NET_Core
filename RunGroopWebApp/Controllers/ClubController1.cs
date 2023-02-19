using Microsoft.AspNetCore.Mvc;

namespace RunGroopWebApp.Controllers
{
	public class ClubController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
