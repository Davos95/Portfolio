using ProyectoFotoCore3.Repository.Context;
namespace ProyectoFotoCore3.Repository.Interfaces
{
    public interface IRepositoryUser
    {
        Users GetById(int id);

        Users GetByNickPassword(string nickname, string password);
    }
}
