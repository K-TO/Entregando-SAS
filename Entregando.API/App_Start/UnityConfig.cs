using Entregando.Data.Repository;
using Entregando.Service;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace Entregando.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //Register all services and repositories for dependency inyection
            //repos
            container.RegisterType<IViajeRepository, ViajeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmpleadoRepository, EmpleadoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IVehiculoRepository, VehiculoRepository>(new HierarchicalLifetimeManager());
            //services
            container.RegisterType<IViajeService, ViajeService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmpleadoService, EmpleadoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IVehiculoService, VehiculoService>(new HierarchicalLifetimeManager());
            //resolver
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}