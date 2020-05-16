using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoFotoCore3.Models.Entities.Apartado.Adapter;
using ProyectoFotoCore3.Models.Entities.Sesion.Adapter;
using ProyectoFotoCore3.Models.Entities.Sesion.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class SesionController : Controller
    {
        private readonly IServiceSesion _serviceSesion;
        private readonly IServiceApartado _serviceApartado;
        public SesionController(IServiceSesion serviceSesion, IServiceApartado serviceApartado)
        {
            _serviceSesion = serviceSesion;
            _serviceApartado = serviceApartado;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetSesions()
        {
            var vmo = _serviceSesion.GetElements().ToList();
            return PartialView("_Sesions", vmo);
        }


        public IActionResult Create()
        {
            var vmo = new SesionVMO();
            vmo.StateView = Models.Enum.StateViewEnum.Nuevo;
            vmo.Apartados = _serviceApartado.GetElements().Select(x => new SelectListItem() { Text = x.Nombre, Value = x.Id.ToString() });

            return PartialView("_ModalSesion", vmo);
        }


        [HttpPost]
        public IActionResult Create(SesionVMO vmo)
        {
            try
            {
                var model = SesionAdapter.ConvertToModel(vmo);
                _serviceSesion.AddElement(model);

                return Json(new { success = true, message = "Se ha creado correctamente" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Ha ocurrido un error" });
            }
        }


    }
}