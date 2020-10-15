// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryModule.cs" company="Cygnet Infotech Pvt Ltd">
//   Copyright © 2015 Cygnet Infotech.
// </copyright>
// <summary>
//   Defines the RepositoryModule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Approach1.Utilities.Bootstrapper.Modules
{
    using Autofac;
    using Infrastructure.Repository;

    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           // Use this when customrepo is defined
            builder.RegisterAssemblyTypes(typeof(BrandRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
