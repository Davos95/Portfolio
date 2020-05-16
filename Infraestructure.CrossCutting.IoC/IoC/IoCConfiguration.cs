using Autofac;
using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore.Repository.Repositories;
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
            builder.RegisterType<ServiceUser>().As<IServiceUsuario>();
            builder.RegisterType<ServiceApartado>().As<IServiceApartado>();
            builder.RegisterType<ServiceSesion>().As<IServiceSesion>();

        }

        public static void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<RepositoryApartado>().As<IRepositoryApartado>();
            builder.RegisterType<RepositorySesion>().As<IRepositorySesion>();
        }
    }
}
