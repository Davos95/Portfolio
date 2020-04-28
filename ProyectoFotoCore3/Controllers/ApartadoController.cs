﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                throw ex;
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