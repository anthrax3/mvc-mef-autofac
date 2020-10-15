// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataModule.cs" company="Cygnet Infotech Pvt Ltd">
//   Copyright © 2015 Cygnet Infotech.
// </copyright>
// <summary>
//   Defines the DataModule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Approach1.Utilities.Bootstrapper.Modules
{
    using Core.Data.Base;
    using Autofac;
    using Infrastructure.Repository;
    using Core.Data;
    using System.Data.Entity;
    using Infrastructure.Data;

    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PrometheusBaseEntities>().AsSelf().As<DbContext>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
        }
    }
}
