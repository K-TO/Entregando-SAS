using System.ComponentModel.DataAnnotations;

namespace Entregando.Infraestructure.Domain
{
    /// <summary>
    /// Entidad de relación entre un empleado y un viaje.
    /// </summary>
    public class EmpleadoViaje
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Id del empleado.
        /// </summary>
        public int EmpleadoId { get; set; }
        
        /// <summary>
        /// Id del viaje.
        /// </summary>
        public int ViajeId { get; set; }
        
        public virtual Empleado Empleado { get; set; }
        public virtual Viaje Viaje { get; set; }
    }
}