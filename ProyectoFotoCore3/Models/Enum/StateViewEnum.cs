using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Enum
{
    public enum StateViewEnum
    {
        [Display(Name = "Nuevo")]
        Nuevo = 1,

        [Display(Name = "Edicion")]
        Edicion = 2,

        [Display(Name = "Lectura")]
        Lectura = 3,
    }
}
