using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceApartado
    {
        Apartado GetElementById(int id);
        List<Apartado> GetElements();
        void AddElement(Apartado element);
        void UpdateElement(Apartado element);
        void DeleteElement(int id);

        int GetNum();
    }
}
