using System;

namespace Entregando.Data.SPModels
{
    /// <summary>
    /// Crea un nuevo viaje.
    /// </summary>
    public class SPViajeModel
    {
        /// <summary>
        /// Id del empleado.
        /// </summary>
        public int EmpleadoId { get; set; }
        
        /// <summary>
        /// Id del vehiculo.
        /// </summary>
        public int VehiculoId { get; set; }

        /// <summary>
        /// Ciudad de salida del viaje.
        /// </summary>
        public string CiudadSalida { get; set; }
        
        /// <summary>
        /// Ciudad de destino del viaje.
        /// </summary>
        public string CiudadDestino { get; set; }
        
        /// <summary>
        /// Nombre del pasajero.
        /// </summary>
        public string NombrePasajero { get; set; }
        
        /// <summary>
        /// Fecha de inicio del viaje.
        /// </summary>
        public DateTime FechaSalida { get; set; }
        
        /// <summary>
        /// Fecha de fin del viaje.
        /// </summary>
        public DateTime? FechaLlegada { get; set; }
        
        /// <summary>
        /// Indica si el articulo fue entregado.
        /// </summary>
        public bool ArticuloEntregado { get; set; }
        
        /// <summary>
        /// Indica si el viaje fue cancelado.
        /// </summary>
        public bool ViajeCancelado { get; set; }
    }
}