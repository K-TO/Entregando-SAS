using Entregando.Data.SPModels;
using Entregando.Infraestructure.Domain;
using System;
using System.Collections.Generic;

namespace Entregando.Service
{
    public interface IViajeService
    {
        List<Viaje> GetAll();

        List<ObtenerViajesEmpleado> GetViajesEmpleado(int empleadoId);

        List<ObtenerViajesEmpleado> GetviajesFilter(DateTime fecha, int empleadoId = 0, string placa = "");

        int AddViaje(SPViajeModel model);
    }
}