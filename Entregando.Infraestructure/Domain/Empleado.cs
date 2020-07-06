using System;
using System.ComponentModel.DataAnnotations;

namespace Entregando.Infraestructure.Domain
{
    /// <summary>
    /// Modelo de datos del empleado.
    /// </summary>
    public class Empleado
    {
        /// <summary>
        /// Id del empleado.
        /// </summary>
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Nombres del empleado.
        /// </summary>
        public string Nombres { get; set; }
        
        /// <summary>
        /// Apellidos del empleado.
        /// </summary>
        public string Apellidos { get; set; }
        
        /// <summary>
        /// Celular del empleado.
        /// </summary>
        public string Celular { get; set; }
        
        /// <summary>
        /// Documento del empleado.
        /// </summary>
        public string Documento { get; set; }
        
        /// <summary>
        /// Email del empleado.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Cargo del empleado en la empresa.
        /// </summary>
        public string Cargo { get; set; }
        
        /// <summary>
        /// Fecha de nacimiento del empleado.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Indica si el empleado tiene hijos.
        /// </summary>
        [Display(Name = "Tiene Hijos")]
        public bool TieneHijos { get; set; }
    }
}