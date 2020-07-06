using Entregando.Service;
using System.Web.Mvc;

namespace Entregando.UI.Controllers
{
    public class HomeController : Controller
    {
        #region Members
        private readonly IEmpleadoService _empleadoService;
        private readonly IViajeService _viajeService;
        #endregion

        #region Ctor
        public HomeController(IEmpleadoService empleadoService, IViajeService viajeService)
        {
            _empleadoService = empleadoService;
            _viajeService = viajeService;
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var viajes = _viajeService.GetViajesEmpleado(50);
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
        #endregion
    }
}