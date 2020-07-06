using Entregando.Data.SPModels;
using System.Collections.Generic;

namespace Entregando.App.Models
{
    public class JsonResponseModel
    {
        public string Messaje { get; set; }
        public bool Error { get; set; }
        //public object Data { get; set; }
        public List<ObtenerViajesEmpleado> Data { get; set; }
    }
}
