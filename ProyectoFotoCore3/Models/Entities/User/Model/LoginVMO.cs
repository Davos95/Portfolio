using Infraestructure.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFotoCore3.Domain.Entities;

namespace ProyectoFotoCore3.Models.Entities.User.Model
{
    public class LoginVMO
    {
        [PropertyTarget(nameof(Domain.Entities.Entities.User.Nick))]
        public string Nickname { get; set; }
        [PropertyTarget(nameof(Domain.Entities.Entities.User.Pwd))]
        public string Password { get; set; }

    }
}
