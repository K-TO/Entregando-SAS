using Entregando.Data.Context;
using Entregando.Infraestructure.Domain;

namespace Entregando.Data.Repository
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {
        #region Members
        #endregion

        #region Ctor
        public VehiculoRepository(EntregandoContext context) : base(context)
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}
