using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Approach1.FrontEnd.MEFFactory;
using Autofac;
using Autofac.Integration.Mvc;
using Approach1.Utilities.Bootstrapper.Modules;

namespace Approach1.FrontEnd
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var pluginFolders = new List<string>();
            var plugins = Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules")).ToList();

            plugins.ForEach(s =>
            {
                var di = new DirectoryInfo(s);
                pluginFolders.Add(di.Name);
            });

            AreaRegistration.RegisterAllAreas();           
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Bootstrapper.Compose(pluginFolders);
            ViewEngines.Engines.Add(new CustomViewEngine(pluginFolders));

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
           
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

      
    }
}
