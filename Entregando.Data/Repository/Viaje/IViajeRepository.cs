using Entregando.Data.SPModels;
using Entregando.Infraestructure.Domain;
using System;
using System.Collections.Generic;

namespace Entregando.Data.Repository
{
    public interface IViajeRepository : IGenericRepository<Viaje>
    {
        List<ObtenerViajesEmpleado> GetViajesEmpleado(int empleadoId);

        List<ObtenerViajesEmpleado> GetViajesEmpleadoFiltert(DateTime fecha, int empleadoId = 0, string placa = "");

        int CreateViaje(SPViajeModel model);
    }
}