using Entregando.Data.Repository;
using Entregando.Data.SPModels;
using Entregando.Infraestructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entregando.Service
{
    public class ViajeService : IViajeService
    {
        #region Members
        private readonly IViajeRepository _repository;
        #endregion

        #region Ctor
        public ViajeService(IViajeRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public List<Viaje> GetAll()
        {
            try
            {
                return _repository.GetAll().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<ObtenerViajesEmpleado> GetViajesEmpleado(int empleadoId)
        {
            try
            {
                return _repository.GetViajesEmpleado(empleadoId);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<ObtenerViajesEmpleado> GetviajesFilter(DateTime fecha, int empleadoId = 0, string placa = "")
        {
            try
            {
                return _repository.GetViajesEmpleadoFiltert(fecha, empleadoId, placa);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int AddViaje(SPViajeModel model)
        {
            try
            {
                return _repository.CreateViaje(model);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
