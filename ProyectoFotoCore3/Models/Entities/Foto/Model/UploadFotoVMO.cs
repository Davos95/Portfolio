using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Foto.Model
{
    public class UploadFotoVMO
    {
        public IEnumerable<SelectListItem> Sesiones { get; set; }
        public int IdSesion { get; set; }
        
        public List<IFormFile> Fotos { get; set; }
    }
}
