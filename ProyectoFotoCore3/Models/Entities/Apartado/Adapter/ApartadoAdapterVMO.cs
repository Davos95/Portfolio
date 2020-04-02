using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Models.Entities.Apartado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFotoCore3.Data.Context;

namespace ProyectoFotoCore3.Models.Entities.Apartado.Adapter
{
    public class ApartadoAdapterVMO
    {

        public static ApartadoVMO Convert(Data.Context.Apartado model)
        {
            var vmo = HelperAdapter<ApartadoVMO, Data.Context.Apartado>.ConvertToVMO(model);

            return vmo;
        }

        public static List<ApartadoVMO> ConvertList(List<Data.Context.Apartado> list)
        {

            return list.Select(x => Convert(x)).ToList();
        }

        public static Data.Context.Apartado ConvertToModel(ApartadoVMO vmo)
        {
            var model = HelperAdapter<ApartadoVMO, Data.Context.Apartado>.ConvertToNewModel(vmo);

            return model;
        }


        public static Data.Context.Apartado ConvertToModel(ApartadoVMO vmo, Data.Context.Apartado model)
        {
            model = HelperAdapter<ApartadoVMO, Data.Context.Apartado>.ConvertToModel(vmo, model);

            return model;
        }
    }
}
