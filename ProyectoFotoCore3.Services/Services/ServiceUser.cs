using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceUser : IServiceUsuario
    {
        IRepositoryUsuario _repositoryUsuario;
        public ServiceUser(IRepositoryUsuario repositoryUser)
        {
            _repositoryUsuario = repositoryUser;
        }

        public Usuario GetElementById(int id)
        {
            try
            {
                var data = _repositoryUsuario.GetById(id);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Usuario Login(string nickname, string password)
        {
            try
            {
                var aux = _repositoryUsuario.GetByNickPassword(nickname, password);
                return aux;
            }catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
