using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class Comision
    {
        public Comision()
        {
            Sesion = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Ordercomision { get; set; }
        public double? Price { get; set; }
        public string Photo { get; set; }
        public string Uriazure { get; set; }

        public virtual ICollection<Sesion> Sesion { get; set; }
    }
}
