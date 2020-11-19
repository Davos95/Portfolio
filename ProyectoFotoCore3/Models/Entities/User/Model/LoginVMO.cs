using Infraestructure.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFotoCore3.Data.Context;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFotoCore3.Models.Entities.User.Model
{
    public class LoginVMO
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [PropertyTarget(nameof(Usuario.Nombre))]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [PropertyTarget(nameof(Usuario.Password))]
        public string Password { get; set; }

    }
}
