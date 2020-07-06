using System.ComponentModel.DataAnnotations;

namespace Entregando.Infraestructure.Domain
{
    public class Vehiculo
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Placa del vehiculo
        /// </summary>
        public string Placa { get; set; }
    }
}
