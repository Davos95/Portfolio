using Infraestructure.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Apartado.Model
{
    public class ApartadoVMO
    {
        [PropertyTarget(nameof(Data.Context.Apartado.Id))]
        public int Id { get; set; }

        [PropertyTarget(nameof(Data.Context.Apartado.Nombre))]
        public string Name { get; set; }

        [PropertyTarget(nameof(Data.Context.Apartado.Descripcion))]
        public string Descripcion { get; set; }

        [PropertyTarget(nameof(Data.Context.Apartado.Precio))]
        public decimal Price { get; set; }
    }
}
