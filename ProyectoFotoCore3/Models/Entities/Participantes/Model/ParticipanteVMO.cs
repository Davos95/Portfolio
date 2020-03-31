using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Models.Base;
using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Participantes.Model
{
    public class ParticipanteVMO : VmoBase
    {
        [PropertyTarget(nameof(Worker.Id))]
        public int Id { get; set; }

        [PropertyTarget(nameof(Worker.Name))]
        public string Name { get; set; }

        [PropertyTarget(nameof(Worker.Contact))]
        public string Contact { get; set; }

        [PropertyTarget(nameof(Worker.Urlcontact))]
        public string Urlcontact { get; set; }

    }
}
