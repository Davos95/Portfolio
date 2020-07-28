using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Services.Builders
{
    public class FotoBuilder
    {
        public static Foto Build(int idSesion, int ordenSesion, string uriAzure)
        {
            var model = new Foto();
            model.IdSesion = idSesion;
            model.OrdenSesion = ordenSesion;
            model.UriAzure = uriAzure;

            return model;
        }

    }
}
