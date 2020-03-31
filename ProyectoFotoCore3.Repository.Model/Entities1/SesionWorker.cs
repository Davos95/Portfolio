using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class SesionWorker
    {
        public int Idsesion { get; set; }
        public int Idworker { get; set; }
        public int? Idwork { get; set; }

        public virtual Sesion IdsesionNavigation { get; set; }
        public virtual Work IdworkNavigation { get; set; }
        public virtual Worker IdworkerNavigation { get; set; }
    }
}
