using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class Foto
    {
        public Foto()
        {
            Sesion = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public int IdSesion { get; set; }
        public string UriAzure { get; set; }
        public bool? Principal { get; set; }
        public int? OrdenSesion { get; set; }
        public int? OrdenPrincipal { get; set; }

        public virtual Sesion IdSesionNavigation { get; set; }
        public virtual ICollection<Sesion> Sesion { get; set; }
    }
}
