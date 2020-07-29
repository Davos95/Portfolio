using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Services.Interfaces
{
    public interface IServiceFoto
    {
        Foto GetElementById(int id);
        List<Foto> GetElements();
        List<Foto> GetElementsByIdSesion(int IdSesion);

        Task UploadFotos(List<FotoDTO> list, int idSesion);

        void AddElement(Foto element, bool save = true);
        void UpdateElement(Foto element);
        Task DeleteElement(int id, bool save = true);
        Task DeleteElements(List<int> ids);
        int GetNum();
        int GetNumFotosBySesion(int IdSesion);

        void OrdenarFotos(String IdFotos, int IdSesion);

        void SetPreviewImageSession(int id);
    }
}
