using Infraestructure.Utils.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoFotoCore3.Models.Base;
using ProyectoFotoCore3.Models.Entities.Apartado.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Sesion.Model
{
    public class SesionVMO: VmoBase
    {
        [PropertyTarget(nameof(Data.Context.Sesion.Id))]
        public int Id { get; set; }

        [PropertyTarget(nameof(Data.Context.Sesion.Nombre))]
        [Required]
        public string Nombre { get; set; }

        [PropertyTarget(nameof(Data.Context.Sesion.Descripcion))]
        public string Descripcion { get; set; }

        [PropertyTarget(nameof(Data.Context.Sesion.Colaboracion))]
        public bool Colaboracion { get; set; }


        [PropertyTarget(nameof(Data.Context.Sesion.IdApartado))]
        [Required]
        public int IdApartado { get; set; }

        public IEnumerable<SelectListItem> Apartados { get; set; }

    }
}
