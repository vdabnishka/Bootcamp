using System.Linq;
using System.Web.Mvc;
using Bootcamp.DataAccess;

namespace Bootcamp.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var context = new BootcampEntities();
			var areas = context.Areas.ToList();

			return View(areas);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}