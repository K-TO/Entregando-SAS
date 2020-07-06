using Entregando.Data.Context;
using System;

namespace Entregando.Data.It
{
    public interface IDbFactory : IDisposable
    {
        EntregandoContext Init();
    }
}