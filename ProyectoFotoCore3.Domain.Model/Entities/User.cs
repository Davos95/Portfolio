using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFotoCore3.Domain.Entities.Entities
{
    public class User
    {
        [PropertyTarget(nameof(Users.Id))]
        public string Id { get; set; }

        [PropertyTarget(nameof(Users.Nick))]
        public string Nick { get; set; }

        [PropertyTarget(nameof(Users.Pwd))]
        public string Pwd { get; set; }

        [PropertyTarget(nameof(Users.Name))]
        public string Name { get; set; }

        [PropertyTarget(nameof(Users.Role))]
        public string Role { get; set; }

    }
}
