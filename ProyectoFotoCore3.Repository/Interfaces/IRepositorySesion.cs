using ProyectoFotoCore.Repository.Interfaces.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore.Repository.Interfaces
{
    public interface IRepositorySesion : IRepository<Sesion>
    {
        Sesion GetById(int id);
        IEnumerable<Sesion> GetByIdApartado(int idApartado);
        int GetNum();


    }
}
