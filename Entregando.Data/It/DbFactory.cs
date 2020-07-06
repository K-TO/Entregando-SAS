using Entregando.Data.Context;

namespace Entregando.Data.It
{
    public class DbFactory : Disposable, IDbFactory
    {
        EntregandoContext dbContext;

        public EntregandoContext Init()
        {
            return dbContext ?? (dbContext = new EntregandoContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}