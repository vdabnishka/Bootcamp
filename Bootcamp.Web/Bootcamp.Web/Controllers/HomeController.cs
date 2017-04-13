using System.Linq;
using System.Web.Mvc;
using Bootcamp.Repositories.Contracts.Queries;
using Bootcamp.Repositories.Queries;
using System.Threading.Tasks;

namespace Bootcamp.Web.Controllers
{
	public class HomeController : Controller
	{
        private IAreaQueries _repo;
        private AreaQueries areaQueries;

        public HomeController() : this(new AreaQueries())
        { }

        public HomeController(AreaQueries repo)
        {
            _repo = repo;
        }

        public async Task<ActionResult> Index()
		{
			var areas = await _repo.Get();

			return View(areas);
		}

        public ActionResult Areas()
        {
            return View();
        }

		public ActionResult AreasTs()
		{
			return View();
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