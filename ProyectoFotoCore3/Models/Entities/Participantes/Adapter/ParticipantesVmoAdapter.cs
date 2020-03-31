using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Models.Entities.Participantes.Model;
using ProyectoFotoCore3.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Participantes.Adapter
{
    public class ParticipantesVmoAdapter
    {

        public static ParticipanteVMO Convert(Worker model)
        {
            var vmo = HelperAdapter<ParticipanteVMO, Worker>.ConvertToVMO(model);

            return vmo;
        }

        public static Worker ConvertToModel(ParticipanteVMO vmo)
        {
            var model = HelperAdapter<ParticipanteVMO, Worker>.ConvertToNewModel(vmo);

            return model;
        }


        public static Worker ConvertToModel(ParticipanteVMO vmo, Worker model)
        {
            model = HelperAdapter<ParticipanteVMO, Worker>.ConvertToModel(vmo, model);

            return model;
        }
    }
}
