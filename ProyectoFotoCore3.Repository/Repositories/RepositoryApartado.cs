using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore.Repository.Repositories.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore.Repository.Repositories
{
    public class RepositoryApartado : Repository<Apartado> ,IRepositoryApartado
    {
        public RepositoryApartado(PortfolioContext context): base(context) { }

        public Apartado GetById(int id)
        {
            var data = _dbSet
                .FirstOrDefault(x => x.Id == id);

            return data;
        }

        public int GetNum() => this.GetAll().Count();

    }
}
