using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Models.Entities.Foto.Model
{
    public class UploadFotoVMO
    {
        public IEnumerable<SelectListItem> Sesiones { get; set; }

        [Required]
        public int IdSesion { get; set; }
        
        public List<IFormFile> Fotos { get; set; }
    }
}
