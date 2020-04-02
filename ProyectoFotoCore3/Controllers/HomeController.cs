using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFotoCore3.Models;
using ProyectoFotoCore3.Models.Entities.Home.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class HomeController : Controller
    {        
        private readonly IServiceUsuario _serviceUser;
        private readonly IServiceApartado _serviceApartado;
        public HomeController(IServiceUsuario serviceUser, IServiceApartado serviceApartado)
        {
            _serviceUser = serviceUser;
            _serviceApartado = serviceApartado;
        }

        public IActionResult Index()
        {
            var vmo = new HomeVMO();
            vmo.Sections = _serviceApartado.GetNum();

            return View(vmo);
        }

        private void Lectura()
        {
            var model = _serviceUser.GetElementById(1);    
        }

    }
}
