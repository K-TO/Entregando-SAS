using Entregando.Infraestructure.Domain;
using Entregando.Infraestructure.Utils;
using Entregando.Service;
using Entregando.UI.Filters;
using Entregando.UI.Models;
using System.Net;
using System.Web.Mvc;

namespace Entregando.UI.Controllers
{
    public class EmpleadoController : Controller
    {
        #region Members
        private readonly IEmpleadoService _empleadoService;
        #endregion

        #region Ctor
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }
        #endregion

        #region Methods
        // GET: Empleado
        public ActionResult Index()
        {
            if (TempData["TempMessage"] != null)
            {
                ViewBag.StartupScript = TempData["TempMessage"];
                TempData["TempMessage"] = null;
            } 
            return View(_empleadoService.GetAll());
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null || id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = _empleadoService.GetById(id.Value);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoViewModel empleado)
        {
            if (ModelState.IsValid)
            {
                Empleado employee = new Empleado();
                PropCopy.Copy(empleado, employee);
                if (_empleadoService.Create(employee))
                {
                    TempData["TempMessage"] = GetMessageNotification(message: "Empleado creado satisfactoriamente.", type: "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.StartupScript = GetMessageNotification(message: "Error al crear el empleado.", type: "danger");
                    return View(empleado);
                }
            }
            return View(empleado);
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = _empleadoService.GetById(id.Value);
            EmpleadoViewModel model = new EmpleadoViewModel();
            if (empleado == null)
            {
                return HttpNotFound();
            }
            else
            {
                PropCopy.Copy(empleado, model);
                return View(model);
            }
        }

        // POST: Empleado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoViewModel empleado)
        {
            if (ModelState.IsValid)
            {
                Empleado employee = new Empleado();
                PropCopy.Copy(empleado, employee);
                if (_empleadoService.Update(employee))
                {
                    TempData["TempMessage"] = GetMessageNotification(message: "Empleado actualizado satisfactoriamente.", type: "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.StartupScript = GetMessageNotification(message: "Error al actualizar el empleado, contacte al administrador.", type: "danger");
                    return View(empleado);
                }
            }
            return View(empleado);
        }

        //// GET: Empleado/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Empleado empleado = db.Empleado.Find(id);
        //    if (empleado == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(empleado);
        //}

        // POST: Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        [CustomTokenValidator]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = _empleadoService.GetById(id);
            if (empleado != null)
            {
                if (_empleadoService.Delete(empleado))
                {
                    TempData["TempMessage"] = GetMessageNotification(message: "Empleado eliminado satisfactoriamente.", type: "success");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.StartupScript = GetMessageNotification(message: "Error al eliminar el empleado, contacte al administrador.", type: "danger");
                    return View(empleado);
                }
            }
            ViewBag.StartupScript = GetMessageNotification(message: "Error al eliminar el empleado, contacte al administrador.", type: "danger");
            return RedirectToAction("Index");
        }
        #endregion

        #region Private methods
        private string GetMessageNotification(string title = "Notificación", string message = "", string type = "default")
        {
            return string.Format("ShowNotificationModal(title = '{0}', message = '{1}', type = '{2}')", title, message, type);
        }
        #endregion
    }
}
