using System;
using System.ComponentModel.DataAnnotations;

namespace Entregando.UI.Models
{
    public class EmpleadoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Los {0} son requeridos.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los {0} son requeridos.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El campo {0} debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "El campo {0} debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [EmailAddress(ErrorMessage = "Este no es un email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El campo {0} debe contener máximo {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú.,]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "La {0} es requerida.")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe responder si el empleado tiene hijos.")]
        public bool TieneHijos { get; set; }
    }
}