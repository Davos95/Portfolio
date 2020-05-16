using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceSesion
    {
        Sesion GetElementById(int id);
        List<Sesion> GetElements();
        void AddElement(Sesion element);
        void UpdateElement(Sesion element);
        void DeleteElement(int id);

        int GetNum();

    }
}
