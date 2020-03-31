using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
