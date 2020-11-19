using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFotoCore3.Models;
using ProyectoFotoCore3.Models.Entities.Home.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {        
        private readonly IServiceUsuario _serviceUser;
        private readonly IServiceApartado _serviceApartado;
        private readonly IServiceSesion _serviceSesion;
        private readonly IServiceFoto _serviceFoto;
        public HomeController(IServiceUsuario serviceUser, IServiceApartado serviceApartado, IServiceSesion serviceSesion, IServiceFoto serviceFoto)
        {
            _serviceUser = serviceUser;
            _serviceApartado = serviceApartado;
            _serviceSesion = serviceSesion;
            _serviceFoto = serviceFoto;
        }

        public IActionResult Index()
        {
            var vmo = new HomeVMO();
            vmo.Sections = _serviceApartado.GetNum();
            vmo.Sessions = _serviceSesion.GetNum();
            vmo.Photos = _serviceFoto.GetNum();

            return View(vmo);
        }

    }
}
