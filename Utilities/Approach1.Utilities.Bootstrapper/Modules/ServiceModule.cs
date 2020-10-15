// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceModule.cs" company="Cygnet Infotech Pvt Ltd">
//   Copyright © 2015 Cygnet Infotech.
// </copyright>
// <summary>
//   Defines the ServiceModule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Approach1.Utilities.Bootstrapper.Modules
{
    using Approach1.Infrastructure.Service;
    using Autofac;

    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BrandService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces()
               .InstancePerLifetimeScope();
        }
    }
}
