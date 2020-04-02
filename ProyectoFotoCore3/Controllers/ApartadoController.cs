using System;
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
            var vmo = new ApartadosVMO();
            vmo.Apartados = ApartadoAdapterVMO.ConvertList(_serviceApartado.GetElements());

            return View(vmo);
        }



        

    }
}