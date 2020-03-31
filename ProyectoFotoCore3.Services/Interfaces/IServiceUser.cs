using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceUser
    {
        Users GetElementById(int id);

        Users Login(string nickname, string password);
    }
}
