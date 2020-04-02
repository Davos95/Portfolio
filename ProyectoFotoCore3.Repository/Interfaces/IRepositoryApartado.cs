using ProyectoFotoCore.Repository.Interfaces.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore.Repository.Interfaces
{
    public interface IRepositoryApartado : IRepository<Apartado>
    {
        Apartado GetById(int id);

        int GetNum();
        
    }
}
