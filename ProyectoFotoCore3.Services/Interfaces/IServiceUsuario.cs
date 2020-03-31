using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceUsuario
    {
        Usuario GetElementById(int id);

        Usuario Login(string nickname, string password);
    }
}
