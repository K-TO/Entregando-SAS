using Entregando.Data.Context;
using Entregando.Data.SPModels;
using Entregando.Infraestructure.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Entregando.Data.Repository
{
    public class ViajeRepository : GenericRepository<Viaje>, IViajeRepository
    {
        #region members
        private readonly EntregandoContext _context;
        #endregion

        #region Ctor
        public ViajeRepository(EntregandoContext context) : base(context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public List<ObtenerViajesEmpleado> GetViajesEmpleado(int empleadoId)
        {
            var parameterEmpleadoId = new SqlParameter { ParameterName = "EmpleadoId", Value = empleadoId };
            return _context.Database.SqlQuery<ObtenerViajesEmpleado>("spObtenerViajesEmpleado @EmpleadoId", parameterEmpleadoId).ToList();
        }

        public List<ObtenerViajesEmpleado> GetViajesEmpleadoFiltert(DateTime fecha, int empleadoId = 0, string placa = "")
        {
            var parameterEmpleadoId = new SqlParameter { ParameterName = "EmpleadoId", Value = empleadoId };
            var parameterPlaca = new SqlParameter { ParameterName = "PlacaVehiculo", Value = placa };
            var parameterfecha = new SqlParameter { ParameterName = "Fecha", Value = fecha };
            return _context.Database.SqlQuery<ObtenerViajesEmpleado>("spObtenerViajesEmpleadoFilter @Fecha, @EmpleadoId, @PlacaVehiculo", parameterfecha, parameterEmpleadoId, parameterPlaca).ToList();
        }

        public int CreateViaje(SPViajeModel model)
        {
            var parameterEmpleadoId = new SqlParameter { ParameterName = "EmpleadoId", Value = model.EmpleadoId };
            var parameterVehiculoId = new SqlParameter { ParameterName = "VehiculoId", Value = model.VehiculoId };
            var parameterCiudadSalida = new SqlParameter { ParameterName = "CiudadSalida", Value = model.CiudadSalida };
            var parameterCiudadDestino = new SqlParameter { ParameterName = "CiudadDestino", Value = model.CiudadDestino };
            var parameterNombrePasajero = new SqlParameter { ParameterName = "NombrePasajero", Value = model.NombrePasajero };
            var parameterFechaSalida = new SqlParameter { ParameterName = "FechaSalida", Value = model.FechaSalida };
            var parameterFechaLlegada = new SqlParameter { ParameterName = "FechaLlegada", Value = model.FechaLlegada };
            var parameterArticuloEntregado = new SqlParameter { ParameterName = "ArticuloEntregado", Value = model.ArticuloEntregado };
            var parameterViajeCancelado = new SqlParameter { ParameterName = "ViajeCancelado", Value = model.ViajeCancelado };

            return _context.Database.SqlQuery<int>("spAgregarViaje @EmpleadoId, @VehiculoId, @CiudadSalida, @CiudadDestino, @NombrePasajero, @FechaSalida, @FechaLlegada, @ArticuloEntregado, @ViajeCancelado",
                parameterEmpleadoId, parameterVehiculoId, parameterCiudadSalida, parameterCiudadDestino, parameterNombrePasajero, parameterFechaSalida, parameterFechaLlegada, parameterArticuloEntregado, parameterViajeCancelado).FirstOrDefault();
        }
        #endregion
    }
}
