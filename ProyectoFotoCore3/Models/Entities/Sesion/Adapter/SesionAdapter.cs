using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Models.Entities.Sesion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Sesion.Adapter
{
    public class SesionAdapter
    {

        public static SesionVMO Convert(Data.Context.Sesion model)
        {
            var vmo = HelperAdapter<SesionVMO, Data.Context.Sesion>.ConvertToVMO(model);

            return vmo;
        }

        public static List<SesionVMO> ConvertList(List<Data.Context.Sesion> list)
        {

            return list.Select(x => Convert(x)).ToList();
        }

        public static Data.Context.Sesion ConvertToModel(SesionVMO vmo)
        {
            var model = HelperAdapter<SesionVMO, Data.Context.Sesion>.ConvertToNewModel(vmo);

            return model;
        }


        public static Data.Context.Sesion ConvertToModel(SesionVMO vmo, Data.Context.Sesion model)
        {
            model = HelperAdapter<SesionVMO, Data.Context.Sesion>.ConvertToModel(vmo, model);

            return model;
        }


    }
}
