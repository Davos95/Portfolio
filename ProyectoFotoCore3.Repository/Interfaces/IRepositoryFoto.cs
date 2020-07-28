using ProyectoFotoCore.Repository.Interfaces.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore.Repository.Interfaces
{
    public interface IRepositoryFoto : IRepository<Foto>
    {
        Foto GetById(int id);
        IEnumerable<Foto> GetByIdSesion(int idSesion);
        int GetNum();

    }
}
