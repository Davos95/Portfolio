using Infraestructure.Utils.Utils;
using ProyectoFotoCore3.Models.Entities.Foto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Foto.Adapter
{
    public class FotoAdapter
    {
        public static FotoVMO Convert(Data.Context.Foto model)
        {
            var vmo = HelperAdapter<FotoVMO, Data.Context.Foto>.ConvertToVMO(model);

            return vmo;
        }

        public static List<FotoVMO> ConvertList(List<Data.Context.Foto> list)
        {

            return list.Select(x => Convert(x)).ToList();
        }

        public static Data.Context.Foto ConvertToModel(FotoVMO vmo)
        {
            var model = HelperAdapter<FotoVMO, Data.Context.Foto>.ConvertToNewModel(vmo);

            return model;
        }


        public static Data.Context.Foto ConvertToModel(FotoVMO vmo, Data.Context.Foto model)
        {
            model = HelperAdapter<FotoVMO, Data.Context.Foto>.ConvertToModel(vmo, model);

            return model;
        }



    }
}
