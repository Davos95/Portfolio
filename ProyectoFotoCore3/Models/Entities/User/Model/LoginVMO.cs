using Infraestructure.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFotoCore3.Data.Context;

namespace ProyectoFotoCore3.Models.Entities.User.Model
{
    public class LoginVMO
    {
        [PropertyTarget(nameof(Usuario.Nombre))]
        public string Nickname { get; set; }
        [PropertyTarget(nameof(Usuario.Password))]
        public string Password { get; set; }

    }
}
