﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore3.Models.Entities.User.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class LoginController : Controller
    {
        private readonly IServiceUsuario _serviceUsuario;
        public LoginController(IServiceUsuario serviceUser)
        {
            _serviceUsuario = serviceUser;
        }

        public IActionResult Index()
        {
            var vmo = new LoginVMO();

            return View(vmo);
        }

        [HttpPost]
        public IActionResult Index(LoginVMO vmo)
        {
            var model = _serviceUsuario.Login(vmo.Nickname, vmo.Password);
            if (model != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Json(new { success = false });
        }
    }
}