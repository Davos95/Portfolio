using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class Sesion
    {
        public Sesion()
        {
            Photo = new HashSet<Photo>();
            SesionWorker = new HashSet<SesionWorker>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Idphoto { get; set; }
        public DateTime? Datesesion { get; set; }
        public int? Idcomision { get; set; }

        public virtual Comision IdcomisionNavigation { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<SesionWorker> SesionWorker { get; set; }
    }
}
