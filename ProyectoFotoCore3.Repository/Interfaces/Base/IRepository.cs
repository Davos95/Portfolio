using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore.Repository.Interfaces.Base
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void AddElement(T entity, bool saveChanges = true);
        void UpdateElement(T entity, bool saveChanges = true);
        void DeleteElement(T entity, bool saveChanges = true);

        void Save();
    }
}
