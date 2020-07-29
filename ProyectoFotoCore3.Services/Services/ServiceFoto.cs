using ProyectoFotoCore.Repository.Interfaces;
using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Domain.DTO;
using ProyectoFotoCore3.ServiceAgents.AzureBlobStorage;
using ProyectoFotoCore3.Services.Builders;
using ProyectoFotoCore3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.Services.Services
{
    public class ServiceFoto : IServiceFoto
    {
        private readonly IRepositoryFoto _repositoryFoto;
        private readonly IServiceSesion _serviceSesion;
        private readonly AzureBlobStorage _azureBlobStorage;

        public ServiceFoto(IRepositoryFoto repositoryFoto, IServiceSesion serviceSesion, AzureBlobStorage azureBlobStorage)
        {
            _repositoryFoto = repositoryFoto;
            _serviceSesion = serviceSesion;
            _azureBlobStorage = azureBlobStorage;
        }

        public void AddElement(Foto element, bool save = true)
        {
            _repositoryFoto.AddElement(element, save);
        }

        public async Task DeleteElement(int id, bool save = true)
        {
            var foto = _repositoryFoto.GetById(id);
            var nombreFoto = foto.UriAzure.Split('/').Last();
            
            var flag = await _azureBlobStorage.EliminarBlob($"sesion{foto.IdSesion}",nombreFoto);
            _repositoryFoto.DeleteElement(foto, save);
        }

        public async Task DeleteElements(List<int> ids)
        {
            if (ids.Any())
            {
                CheckFotoPreview(ids);
                foreach (var id in ids)
                {
                    await this.DeleteElement(id, false);
                }

                _repositoryFoto.Save();
            }
        }



        public Foto GetElementById(int id)
        {
            return _repositoryFoto.GetById(id);
        }

        public List<Foto> GetElements()
        {
            return _repositoryFoto.GetAll().ToList();
        }

        public List<Foto> GetElementsByIdSesion(int IdSesion)
        {
            return _repositoryFoto.GetByIdSesion(IdSesion).OrderBy(x => x.OrdenSesion).ToList();
        }

        public int GetNum()
        {
            return _repositoryFoto.GetNum();
        }

        public int GetNumFotosBySesion(int IdSesion)
        {
            return this.GetElementsByIdSesion(IdSesion).Count();
        }

        public void OrdenarFotos(string IdFotos, int IdSesion)
        {
            var fotos = this.GetElementsByIdSesion(IdSesion);
            var ids = IdFotos.Split(",");

            for (int i = 0; i < fotos.Count(); i++)
            {
                var foto = fotos.Where(x => x.Id.ToString() == ids[i]).First();
                foto.OrdenSesion = i;
                _repositoryFoto.UpdateElement(foto, false);
            }
            _repositoryFoto.Save();
        }

        public void SetPreviewImageSession(int id)
        {
            var foto = this.GetElementById(id);
            var sesion = _serviceSesion.GetElementById(foto.IdSesion);
            sesion.IdFotoPreview = id;
            _serviceSesion.UpdateElement(sesion);
        }

        public void UpdateElement(Foto element)
        {
            _repositoryFoto.UpdateElement(element);
        }

        public async Task UploadFotos(List<FotoDTO> list, int idSesion)
        {
            await _azureBlobStorage.CrearContenedor("sesion" + idSesion.ToString());

            var order = this.GetNumFotosBySesion(idSesion);

            foreach (FotoDTO foto in list)
            {
                await _azureBlobStorage.SubirBlob($"sesion{idSesion}", foto.Nombre, foto.Path);
                String uri = await _azureBlobStorage.GetUriBlob("sesion" + idSesion.ToString(), foto.Nombre);

                var model = FotoBuilder.Build(idSesion, order, uri);
                _repositoryFoto.AddElement(model, false);

                order++;
            }

            _repositoryFoto.Save();
        }

        private void CheckFotoPreview(List<int> ids)
        {
            var id = ids.First();
            var foto = this.GetElementById(id);
            var sesion = _serviceSesion.GetElementById(foto.IdSesion);
            if (sesion.IdFotoPreview != null && ids.Contains(sesion.IdFotoPreview.Value))
            {
                sesion.IdFotoPreview = null;
                _serviceSesion.UpdateElement(sesion);
            }
        }
    }
}
