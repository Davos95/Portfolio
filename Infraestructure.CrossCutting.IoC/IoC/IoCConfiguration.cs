using Autofac;
using ProyectoFotoCore3.Repository.Interfaces;
using ProyectoFotoCore3.Repository.Repositories;
using ProyectoFotoCore3.Services.Interfaces;
using ProyectoFotoCore3.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.CrossCutting.IoC.IoC
{
    public class IoCConfiguration
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            //builder.RegisterType<ServiceUser>().As<IServiceUser>();
            //builder.RegisterType<ServiceParticipantes>().As<IServiceParticipantes>();

        }

        public static void RegisterRepositories(ContainerBuilder builder)
        {
            //builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            //builder.RegisterType<RepositoryParticipantes>().As<IReposityParticipantes>();
        }
    }
}
