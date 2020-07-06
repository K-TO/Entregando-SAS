using Entregando.API.Models;
using Entregando.Data.SPModels;
using Entregando.Infraestructure.Utils;
using Entregando.Service;
using System;
using System.Linq;
using System.Web.Http;

namespace Entregando.API.Controllers
{
    public class ViajeController : ApiController
    {
        #region Members
        private readonly IViajeService _viajeService;
        #endregion

        #region Ctor
        public ViajeController(IViajeService viajeService)
        {
            _viajeService = viajeService;
        }
        #endregion

        #region Methods
        // GET api/viaje
        /// <summary>
        /// Obtiene todos los viajes realizados.
        /// </summary>
        /// <returns>Viajes registrados por los empleados.</returns>
        public IHttpActionResult Get()
        {
            JsonResponseModel model = new JsonResponseModel()
            {
                Data = _viajeService.GetAll(),
                Messaje = "Datos obtenidos satisfactoriamente",
                Error = false
            };
            return Ok(model);
        }

        // GET api/viajes/5
        /// <summary>
        /// Obtiene los viajes realizados por un empleado.
        /// </summary>
        /// <param name="empleadoId">Id del empleado.</param>
        /// <returns>Listado de viajes realizados por el empleado.</returns>
        public IHttpActionResult Get(int empleadoId)
        {
            JsonResponseModel model = new JsonResponseModel()
            {
                Error = true
            };
            if (empleadoId <= 0)
            {
                model.Messaje = "El id del empleado no es valido";
            }
            else
            {
                model.Data = _viajeService.GetViajesEmpleado(empleadoId);
                model.Messaje = "Datos obtenidos satisfactoriamente";
                model.Error = false;
            }
            return Ok(model);
        }

        //POST api/viajes/
        /// <summary>
        /// Obtiene los viajes realizados por el empleado basandose en los datos del filtro.
        /// </summary>
        /// <param name="fecha">Fecha en la que se realizo el viaje o el viaje estuvo en proceso.</param>
        /// <param name="empleadoId">Id del empleado.</param>
        /// <param name="placa">Placa del vehiculo.</param>
        /// <returns></returns>
        [Route("api/GetFilterViajes")]
        public IHttpActionResult GetFilter(DateTime fecha, int empleadoId = 0, string placa = "")
        {
            JsonResponseModel model = new JsonResponseModel()
            {
                Data = _viajeService.GetviajesFilter(fecha, empleadoId, placa),
                Messaje = "Datos obtenidos satisfactoriamente",
                Error = false
            };
            return Ok(model);
        }

        // POST api/viajes
        /// <summary>
        /// Registra un viaje.
        /// </summary>
        /// <param name="model">Modelo de viaje.</param>
        /// <returns>Objeto que anuncia si el viaje fue creado satisfactoriamente.</returns>
        public IHttpActionResult Post([FromBody] ViajeViewModel model)
        {
            JsonResponseModel response = new JsonResponseModel()
            {
                Data = "",
                Messaje = "Viaje creado satisfactoriamente",
                Error = false
            };
            if (ModelState.IsValid)
            {
                SPViajeModel viajeModel = new SPViajeModel();
                PropCopy.Copy(model, viajeModel);
                if (_viajeService.AddViaje(viajeModel) <= 0)
                {
                    response.Error = true;
                    response.Messaje = "Error al crear el viaje, revise los datos e intente nuevamente.";
                }
            }
            else
            {
                response.Error = true;
                response.Messaje = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
            }
            return Ok(response);
        }
        #endregion
    }
}
