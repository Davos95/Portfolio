using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using ProyectoFotoCore3.Models.Entities.Apartado.Adapter;
using ProyectoFotoCore3.Models.Entities.Apartado.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class ApartadoController : Controller
    {
        private readonly IServiceApartado _serviceApartado;

        public ApartadoController(IServiceApartado serviceApartado)
        {
            _serviceApartado = serviceApartado;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            var vmo = new ApartadoVMO();
            vmo.StateView = Models.Enum.StateViewEnum.Nuevo;

            return PartialView("_ModalApartado", vmo);
        }

        [HttpPost]
        public IActionResult Create(ApartadoVMO vmo)
        {
            try
            {
                var model = ApartadoAdapterVMO.ConvertToModel(vmo);
                _serviceApartado.AddElement(model);

                return Json(new { success = true, message = "Se ha creado correctamente" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Edit(int id)
        {
            var model = _serviceApartado.GetElementById(id);
            var vmo = ApartadoAdapterVMO.Convert(model);
            vmo.StateView = Models.Enum.StateViewEnum.Edicion;

            return PartialView("_ModalApartado", vmo);
        }

        [HttpPost]
        public IActionResult Edit(ApartadoVMO vmo)
        {
            try
            {
                var model = _serviceApartado.GetElementById(vmo.Id);
                model = ApartadoAdapterVMO.ConvertToModel(vmo, model);
                _serviceApartado.UpdateElement(model);

                return Json(new { success = true, message = "Se ha editado correctamente" });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var model = _serviceApartado.GetElementById(id);
                if (model.Sesion.Any())
                {
                    return Json(new { success = true, message = "No se puede eliminar, hay sesiones que pertenecen a este apartado." });
                }

                _serviceApartado.DeleteElement(id);

                return Json(new { success = true, message = "Se ha eliminado correctamente" });
            }
            catch(Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public IActionResult GetTabla()
        {
            var vmo = new ApartadosVMO();
            vmo.Apartados = ApartadoAdapterVMO.ConvertList(_serviceApartado.GetElements());

            return PartialView("_TablaApartado", vmo);
        }

    }
}