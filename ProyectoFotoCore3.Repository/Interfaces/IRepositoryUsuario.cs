using ProyectoFotoCore3.Data.Context;

namespace ProyectoFotoCore3.Repository.Interfaces
{
    public interface IRepositoryUsuario
    {
        Usuario GetById(int id);

        Usuario GetByNickPassword(string nickname, string password);
    }
}
