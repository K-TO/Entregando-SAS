using System;

namespace Entregando.Data.SPModels
{
    public class ObtenerViajesEmpleado
    {
        /// <summary>
        /// Ciudad de salida del viaje
        /// </summary>
        public string CiudadSalida { get; set; }
        
        /// <summary>
        /// Ciudad de destino del viaje.
        /// </summary>
        public string CiudadDestino { get; set; }
        
        /// <summary>
        /// Nombre del pasajero que viaja.
        /// </summary>
        public string NombrePasajero { get; set; }
        
        /// <summary>
        /// Placa del vehiculo
        /// </summary>
        public string Placa { get; set; }
        
        /// <summary>
        /// Viajes realizados por el usuario.
        /// </summary>
        public int ViajesRealizados { get; set; }
        
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
        public string ArticuloEntregado { get; set; }
        
        /// <summary>
        /// Indica si el viaje fue cancelado.
        /// </summary>
        public string ViajeCancelado { get; set; }
        
        /// <summary>
        /// Días que dura el viaje.
        /// </summary>
        public int DiasDeViaje { get; set; }
    }
}
