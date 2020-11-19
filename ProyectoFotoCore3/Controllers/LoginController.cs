using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
        public async Task<IActionResult> Index(LoginVMO vmo)
        {
            var model = _serviceUsuario.Login(vmo.Nickname, vmo.Password);
            if (model != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Nombre),
                    new Claim(ClaimTypes.Role, "Administrator")
                };
                var claimsIdentity = new ClaimsIdentity(claims, "User");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            return Json(new { success = false });
        }
    }
}