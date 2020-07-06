using Autofac;
using Autofac.Integration.Mvc;
using Entregando.Data.Context;
using Entregando.Data.It;
using Entregando.Data.Repository;
using Entregando.Infraestructure.Domain;
using Entregando.Service;
using System.Reflection;
using System.Web.Mvc;

namespace Entregando.UI.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
            //Automaper begin
            //AutoMapperConfiguration.Configure();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();

            //Controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<EntregandoContext>().As<EntregandoContext>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //Habilita la dependencia en los filtros de MVC
            builder.RegisterFilterProvider();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(EmpleadoRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(ViajeRepository).Assembly)
               .Where(t => t.Name.EndsWith("Repository"))
               .AsImplementedInterfaces().InstancePerRequest();

            //Services
            builder.RegisterAssemblyTypes(typeof(EmpleadoService).Assembly)
             .Where(t => t.Name.EndsWith("Service"))
             .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(ViajeService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}