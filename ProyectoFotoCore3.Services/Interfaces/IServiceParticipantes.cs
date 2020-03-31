using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceParticipantes
    {
        Worker GetElementById(int id);
        List<Worker> GetList();
        void AddElement(Worker element);
        void UpdateElement(Worker element);
    }
}
