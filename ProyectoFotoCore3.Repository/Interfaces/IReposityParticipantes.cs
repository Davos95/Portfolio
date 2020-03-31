using ProyectoFotoCore.Repository.Interfaces.Base;
using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Repository.Interfaces
{
    public interface IReposityParticipantes : IRepository<Worker>
    {
        Worker GetElementById(int id);
        List<Worker> GetList();

    }
}
