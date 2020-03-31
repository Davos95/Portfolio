using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class Work
    {
        public Work()
        {
            SesionWorker = new HashSet<SesionWorker>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SesionWorker> SesionWorker { get; set; }
    }
}
