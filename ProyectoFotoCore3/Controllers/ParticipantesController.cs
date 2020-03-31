using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Utils.Utils;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore3.Models.Entities.Participantes.Adapter;
using ProyectoFotoCore3.Models.Entities.Participantes.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class ParticipantesController : Controller
    {
        private readonly IServiceParticipantes _serviceParticipantes;
        public ParticipantesController(IServiceParticipantes serviceParticipantes)
        {
            _serviceParticipantes = serviceParticipantes;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {

            return Content("algo");
        }

        public IActionResult Create()
        {
            var vmo = new ParticipanteVMO();
            vmo.StateView = Models.Enum.StateViewEnum.Nuevo;

            return PartialView("_ParticipantesForm", vmo);
        }

        [HttpPost]
        public JsonResult Create(ParticipanteVMO vmo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = ParticipantesVmoAdapter.ConvertToModel(vmo);
                    _serviceParticipantes.AddElement(model);

                    return Json(new { success = true });
                }

                return Json(new { success = false });
            }
            catch
            {
                return Json(new { success = false });
            }

        }

        public IActionResult Edit(int id)
        {
            try
            {
                var model = _serviceParticipantes.GetElementById(id);
                var vmo = ParticipantesVmoAdapter.Convert(model);

                return View(vmo);
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public IActionResult Edit(ParticipanteVMO vmo)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var model = _serviceParticipantes.GetElementById(vmo.Id);
                    if(model != null)
                    {
                        model = ParticipantesVmoAdapter.ConvertToModel(vmo, model);
                        _serviceParticipantes.UpdateElement(model);

                        return Json(new { success = true });
                    }
                }

                return Json(new { success = false });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        public IActionResult ParticipantesList()
        {
            var model = _serviceParticipantes.GetList();
            var vmo = model.Select(x => ParticipantesVmoAdapter.Convert(x)).ToList();

            return PartialView("_ParticipantesList",vmo);
        }
    }
}