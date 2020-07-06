namespace Entregando.API.Models
{
    /// <summary>
    /// Objeto por defecto para respuestas tipo json.
    /// </summary>
    public class JsonResponseModel
    {
        /// <summary>
        /// Message del sistema.
        /// </summary>
        public string Messaje { get; set; }
        
        /// <summary>
        /// Identifica si el resultado es un error.
        /// </summary>
        public bool Error { get; set; }

        /// <summary>
        /// Datos obtenidos por el servicio.
        /// </summary>
        public object Data { get; set; }
    }
}