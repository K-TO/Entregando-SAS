using Entregando.API.Models;
using Entregando.Service;
using System.Web.Http;

namespace Entregando.API.Controllers
{
    public class VehiculoController : ApiController
    {
        #region Members
        private readonly IVehiculoService _vehiculoService;
        #endregion

        #region Ctor
        public VehiculoController(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }
        #endregion

        #region Methods
        // GET api/vehiculo
        /// <summary>
        /// Obtiene los vehiculos registrados en el sistema.
        /// </summary>
        /// <returns>Listado de vehiculos registrados.</returns>
        public IHttpActionResult Get()
        {
            JsonResponseModel response = new JsonResponseModel()
            {
                Error = false,
                Data = _vehiculoService.GetAll(),
                Messaje = ""
            };
            return Ok(response);
        }
        #endregion
    }
}
