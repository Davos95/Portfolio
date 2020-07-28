using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class Sesion
    {
        public Sesion()
        {
            Foto = new HashSet<Foto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdApartado { get; set; }
        public bool Colaboracion { get; set; }
        public int? IdFotoPreview { get; set; }

        public virtual Apartado IdApartadoNavigation { get; set; }
        public virtual Foto IdFotoPreviewNavigation { get; set; }
        public virtual ICollection<Foto> Foto { get; set; }
    }
}
