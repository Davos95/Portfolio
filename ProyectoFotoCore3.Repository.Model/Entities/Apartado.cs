﻿using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class Apartado
    {
        public Apartado()
        {
            Sesion = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public ICollection<Sesion> Sesion { get; set; }
    }
}
