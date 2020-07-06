using Entregando.Data.Repository;
using Entregando.Infraestructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entregando.Service
{
    public class VehiculoService : IVehiculoService
    {
        #region Members
        private readonly IVehiculoRepository _vehiculoRepository;
        #endregion

        #region Ctor
        public VehiculoService(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }
        #endregion

        #region Methods
        public List<Vehiculo> GetAll()
        {
            try
            {
                return _vehiculoRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
