using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceSesion : IServiceSesion
    {
        private readonly IRepositorySesion _repositorySesion;
        public ServiceSesion(IRepositorySesion repositorySesion)
        {
            _repositorySesion = repositorySesion;
        }

        public void AddElement(Sesion element)
        {
            _repositorySesion.AddElement(element);
        }

        public void DeleteElement(int id)
        {
            var sesion =_repositorySesion.GetById(id);

            _repositorySesion.DeleteElement(sesion);
        }

        public Sesion GetElementById(int id)
        {
            return _repositorySesion.GetById(id);
        }

        public List<Sesion> GetElements()
        {
            return _repositorySesion.GetAll().ToList();
        }

        public int GetNum()
        {
            return _repositorySesion.GetNum();
        }

        public void UpdateElement(Sesion element)
        {
            _repositorySesion.UpdateElement(element);
        }
    }
}
