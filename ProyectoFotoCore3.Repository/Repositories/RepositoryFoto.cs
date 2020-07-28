using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore.Repository.Repositories.Base;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore.Repository.Repositories
{
    public class RepositoryFoto : Repository<Foto>, IRepositoryFoto
    {
        public RepositoryFoto(PortfolioContext context) : base(context) { }

        public Foto GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Foto> GetByIdSesion(int idSesion)
        {
            return _dbSet.Where(x => x.IdSesion == idSesion);

        }

        public int GetNum()
        {
            return _dbSet.Count();
        }
    }
}
