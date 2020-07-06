using Entregando.Infraestructure.Domain;
using System.Collections.Generic;

namespace Entregando.Service
{
    public interface IVehiculoService
    {
        List<Vehiculo> GetAll();
    }
}
