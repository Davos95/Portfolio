using Infraestructure.Utils.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Foto.Model
{
    public class FotoVMO
    {
        public FotoVMO() { }

        public FotoVMO(int idSesion, string uriAzure, int ordenSesion) {
            IdSesion = idSesion;
            UriAzure = uriAzure;
            OrdenSesion = ordenSesion;
        }

        [PropertyTarget(nameof(Data.Context.Foto.Id))]
        public int Id { get; set; }

        [PropertyTarget(nameof(Data.Context.Foto.IdSesion))]
        public int IdSesion { get; set; }

        [PropertyTarget(nameof(Data.Context.Foto.UriAzure))]
        public string UriAzure { get; set; }

        [PropertyTarget(nameof(Data.Context.Foto.Principal))]
        public bool? Principal { get; set; }

        [PropertyTarget(nameof(Data.Context.Foto.OrdenSesion))]
        public int? OrdenSesion { get; set; }

        [PropertyTarget(nameof(Data.Context.Foto.OrdenPrincipal))]
        public int? OrdenPrincipal { get; set; }

    }
}
