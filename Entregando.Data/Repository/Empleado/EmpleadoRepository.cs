using Entregando.Data.Context;
using Entregando.Data.It;
using Entregando.Infraestructure.Domain;

namespace Entregando.Data.Repository
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoRepository
    {
        #region Members

        #endregion

        #region Ctor
        public EmpleadoRepository(EntregandoContext context) : base (context)
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}
