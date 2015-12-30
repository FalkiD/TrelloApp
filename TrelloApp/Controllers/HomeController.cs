using System.Web.Mvc;

namespace TrelloApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public string EnterTrello()
        {
            return "EnterTrello()";
        }
    }
}
