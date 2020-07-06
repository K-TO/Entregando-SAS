using System;
using System.ComponentModel.DataAnnotations;

namespace Entregando.API.Models
{
    public class ViajeViewModel
    {
        /// <summary>
        /// Id del empleado.
        /// </summary>
        [Required(ErrorMessage = "El id del empleado es requerido.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El id del empleado debe ser un número.")]
        public int EmpleadoId { get; set; }

        /// <summary>
        /// Id del vehiculo.
        /// </summary>
        [Required(ErrorMessage = "El id del vehículo es requerido.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El id del vehículo debe ser un número.")]
        public int VehiculoId { get; set; }

        /// <summary>
        /// Ciudad desde la cual se inicia el viaje.
        /// </summary>
        [Required(ErrorMessage = "La ciudad de salida es requerida.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La ciudad de salida debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "La ciudad de salida contiene caracteres inválidos.")]
        public string CiudadSalida { get; set; }

        /// <summary>
        /// Ciudad de destino del viaje.
        /// </summary>
        [Required(ErrorMessage = "La ciudad de destino es requerida.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La ciudad de destino debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "La ciudad de destino contiene caracteres inválidos.")]
        public string CiudadDestino { get; set; }

        /// <summary>
        /// Nombre del pasajero.
        /// </summary>
        [Required(ErrorMessage = "El nombre del pasajero es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La ciudad de destino debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "La ciudad de destino contiene caracteres inválidos.")]
        public string NombrePasajero { get; set; }

        /// <summary>
        /// Fecha de inicio del viaje.
        /// </summary>
        [Required(ErrorMessage = "La fecha de salida es requerida.")]
        public DateTime FechaSalida { get; set; }

        /// <summary>
        /// Fecha de fin del viaje.
        /// </summary>
        [Required(ErrorMessage = "La fecha de llegada es requerida.")]
        public DateTime? FechaLlegada { get; set; }

        /// <summary>
        /// Indica si el articulo fue entregado.
        /// </summary>
        [Required(ErrorMessage = "Debe indicar si se entrego el articulo.")]
        public bool ArticuloEntregado { get; set; }

        /// <summary>
        /// Indica si el viaje fue cancelado.
        /// </summary>
        [Required(ErrorMessage = "Debe indicar si el viaje fue cancelado.")]
        public bool ViajeCancelado { get; set; }
    }
}