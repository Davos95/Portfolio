using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore.Repository.Repositories.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore.Repository.Repositories
{
    public class RepositorySesion : Repository<Sesion>, IRepositorySesion
    {
        public RepositorySesion(PortfolioContext context) : base(context) { }

        public Sesion GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Sesion> GetByIdApartado(int idApartado)
        {
            return _dbSet.Where(x => x.IdApartado == idApartado);
        }

        public int GetNum()
        {
            return _dbSet.ToList().Count();
        }
    }
}
