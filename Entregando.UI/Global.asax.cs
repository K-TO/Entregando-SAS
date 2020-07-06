using Entregando.Data.Context;
using System.Data.Entity;
using Entregando.Data.Migrations;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Entregando.UI.App_Start;

namespace Entregando.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Begin mod by: David Hernández
            //Migrations or init DB
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntregandoContext, Configuration>());
            var entities = new EntregandoContext();
            entities.Database.Initialize(true);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Bootstraper with dependences inyection
            Bootstrapper.Run();
        }
    }
}
