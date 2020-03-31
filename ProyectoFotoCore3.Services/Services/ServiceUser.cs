using ProyectoFotoCore3.Repository.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceUser : IServiceUser
    {
        IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public Users GetElementById(int id)
        {
            try
            {
                var data = _repositoryUser.GetById(id);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Users Login(string nickname, string password)
        {
            try
            {
                var aux = _repositoryUser.GetByNickPassword(nickname, password);
                return aux;
            }catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
