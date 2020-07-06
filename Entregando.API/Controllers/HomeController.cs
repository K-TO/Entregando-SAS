using System.Web.Mvc;

namespace Entregando.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Pagína de inicio - Entregando SAS";
            return View();
        }
    }
}
