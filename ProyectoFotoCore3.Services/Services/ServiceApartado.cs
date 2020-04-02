using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceApartado : IServiceApartado
    {
        private readonly IRepositoryApartado _repositoryApartado;

        public ServiceApartado(IRepositoryApartado repositoryApartado)
        {
            _repositoryApartado = repositoryApartado;
        }

        public void AddElement(Apartado element)
        {
            try
            {
                _repositoryApartado.AddElement(element);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteElement(int id)
        {
            try
            {
                 var element = _repositoryApartado.GetById(id);
                _repositoryApartado.DeleteElement(element);
            }
            catch (Exception ex)
            {

            }
        }

        public Apartado GetElementById(int id)
        {
            return _repositoryApartado.GetById(id);
        }

        public List<Apartado> GetElements()
        {
            return _repositoryApartado.GetAll().ToList();
        }

        public int GetNum()
        {
            return _repositoryApartado.GetNum();
        }

        public void UpdateElement(Apartado element)
        {
            try
            {
                _repositoryApartado.UpdateElement(element);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
