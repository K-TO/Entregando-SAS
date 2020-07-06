using Entregando.API.Models;
using Entregando.Service;
using System.Web.Http;

namespace Entregando.API.Controllers
{
    public class EmpleadoController : ApiController
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
        //Get api/empleado
        /// <summary>
        /// Obtiene los empleados registrados en el sistema.
        /// </summary>
        /// <returns>Listado de empleados registrados.</returns>
        public IHttpActionResult Get()
        {
            JsonResponseModel model = new JsonResponseModel()
            {
                Data = _empleadoService.GetAll(),
                Messaje = "Datos obtenidos satisfactoriamente",
                Error = false
            };
            return Ok(model);
        }
        #endregion
    }
}
