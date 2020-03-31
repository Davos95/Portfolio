using ProyectoFotoCore.Repository.Repositories.Base;
using ProyectoFotoCore3.Repository.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore3.Repository.Repositories
{
    public class RepositoryParticipantes : Repository<Worker>, IReposityParticipantes
    {
        public RepositoryParticipantes(PictureManagerContext context) : base(context) { }

        public Worker GetElementById(int id)
        {
            var datos = _dbSet.FirstOrDefault(x => x.Id == id);

            return datos;
        }

        public List<Worker> GetList()
        {
            var datos = _dbSet.ToList();
            return datos;
        }

    }
}
