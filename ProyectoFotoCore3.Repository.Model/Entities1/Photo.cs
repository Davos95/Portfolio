using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class Photo
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public int? Idsesion { get; set; }
        public int? Orderphoto { get; set; }
        public bool Favorite { get; set; }
        public int? Orderfavorite { get; set; }
        public string Uriazure { get; set; }

        public virtual Sesion IdsesionNavigation { get; set; }
    }
}
