using System;

namespace Entregando.API.Models
{
    /// <summary>
    /// Modelo usado para filtrar la información de viajes.
    /// </summary>
    public class FilterModel
    {
        /// <summary>
        /// Fecha del viaje
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Id del empleado que realizo el viaje,
        /// </summary>
        public int EmpleadoId { get; set; }

        /// <summary>
        /// Placa del vehiculo.
        /// </summary>
        public string Placa { get; set; }
    }
}