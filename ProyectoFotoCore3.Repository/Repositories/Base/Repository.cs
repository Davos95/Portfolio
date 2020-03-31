using Microsoft.EntityFrameworkCore;
using ProyectoFotoCore.Repository.Interfaces.Base;
using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFotoCore.Repository.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly PictureManagerContext _context;
        internal DbSet<T> _dbSet;

        public Repository(PictureManagerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual void AddElement(T entity, bool saveChanges = true)
        {
            _dbSet.Add(entity);
            if (saveChanges)
                Save();
        }

        public virtual void UpdateElement(T entity, bool saveChanges = true)
        {
            _dbSet.Update(entity);
            if (saveChanges)
                Save();
        }

        public virtual void DeleteElement(T entity, bool saveChanges = true)
        {
            _dbSet.Remove(entity);
            if (saveChanges)
                Save();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();

        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
