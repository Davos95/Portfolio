using ProyectoFotoCore3.Repository.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceParticipantes : IServiceParticipantes
    {
        private readonly IReposityParticipantes _repositoryParticipantes;

        public ServiceParticipantes(IReposityParticipantes repositoryParticipantes) 
        {
            _repositoryParticipantes = repositoryParticipantes;
        }

        public Worker GetElementById(int id)
        {
            try
            {
                var aux = _repositoryParticipantes.GetElementById(id);
                return aux;

            } catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public List<Worker> GetList()
        {
            try
            {
                var aux = _repositoryParticipantes.GetList();
                return aux;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void AddElement(Worker element)
        {
            try
            {
                _repositoryParticipantes.AddElement(element);
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateElement(Worker element)
        {
            try
            {
                _repositoryParticipantes.UpdateElement(element);

            }
            catch (Exception ex)
            {
                throw;
            }
        }



    }
}
