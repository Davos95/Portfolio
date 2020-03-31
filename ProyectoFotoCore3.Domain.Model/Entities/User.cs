using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Domain.Entities.Entities
{
    public class User
    {
        [PropertyTarget(nameof(Usuario.Id))]
        public string Id { get; set; }

        [PropertyTarget(nameof(Usuario.Nombre))]
        public string Name { get; set; }

        [PropertyTarget(nameof(Usuario.Password))]
        public string Pwd { get; set; }
    }
}
