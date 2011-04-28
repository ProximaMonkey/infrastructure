using System.Web.Mvc;

namespace Solution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = Resources.Index.IndexHeading;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
