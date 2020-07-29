using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Utils.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using ProyectoFotoCore3.Domain.DTO;
using ProyectoFotoCore3.Models.Entities.Foto.Adapter;
using ProyectoFotoCore3.Models.Entities.Foto.Model;
using ProyectoFotoCore3.Models.Entities.Sesion.Model;
using ProyectoFotoCore3.Services.Interfaces;

namespace ProyectoFotoCore3.Controllers
{
    public class FotoController : Controller
    {

        private readonly IServiceSesion _serviceSesion;
        private readonly IServiceFoto _serviceFoto;

        public FotoController(IServiceSesion serviceSesion, IServiceFoto serviceFoto)
        {
            _serviceSesion = serviceSesion;
            _serviceFoto = serviceFoto;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult UploadModal()
        {

            var vmo = new UploadFotoVMO();

            vmo.Sesiones = _serviceSesion.GetElements().Select(x => new SelectListItem { Text = x.Nombre, Value = x.Id.ToString() });

            return PartialView("_ModalUpload", vmo);
        }


        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> files, int IdSesion)
        {
            try
            {
                var dtoList = new List<FotoDTO>();

                foreach (IFormFile file in files)
                {
                    var dto = new FotoDTO();
                    dto.Nombre = file.FileName;
                    dto.Path = Path.GetTempFileName();

                    using (var stream = new FileStream(dto.Path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    dtoList.Add(dto);
                }

                await _serviceFoto.UploadFotos(dtoList, IdSesion);

                return Json(new { success = true });
            }
            catch(Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public int GetNumPhotos()
        {

            return _serviceFoto.GetNum();
        }

        [HttpPost]
        public IActionResult Ordenar(String IdFotos, int IdSesion)
        {
            try
            {
                if (String.IsNullOrEmpty(IdFotos)) 
                { 
                    return Json(new { success = true, message = "No hay fotos que ordenar" }); 
                }

                _serviceFoto.OrdenarFotos(IdFotos, IdSesion);

                return Json(new { success = true, message = "Se ha ordenado correctamente" });
            } 
            catch (Exception ex)
            {

                return Json(new { success = true, message = "Ha ocurrido un error, por favor vuelve a intentarlo" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFotos(string IdFotos)
        {
            try
            {
                var listId = new List<int>();
                var ids = IdFotos.Split(',');
                foreach (var id in ids)
                {
                    listId.Add(int.Parse(id));
                }

                await _serviceFoto.DeleteElements(listId);

                return Json(new { success = true, message = "Se ha ordenado correctamente" });
            }
            catch(Exception ex)
            {
                return Json(new { success = true, message = "Ha ocurrido un error, por favor vuelve a intentarlo" });
            }
        }

        public IActionResult PreviewImage(int id)
        {
            try
            {
                _serviceFoto.SetPreviewImageSession(id);

                return Json(new { sucess = true });
            }
            catch(Exception ex)
            {
                return Json(new { sucess = false, message = ex.Message });
            }
        }
    }
}