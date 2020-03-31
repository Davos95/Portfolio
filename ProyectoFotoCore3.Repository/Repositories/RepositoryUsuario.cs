using ProyectoFotoCore3.Data.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using System.Linq;

namespace ProyectoFotoCore3.Repository.Repositories
{
    public class RepositoryUsuario: IRepositoryUsuario
    {
        private readonly PortfolioContext _context;
        public RepositoryUsuario(PortfolioContext context)
        {
            _context = context;
        }

        public Usuario GetById(int id)
        {
            var datos = _context.Usuario.FirstOrDefault(x => x.Id == id);
            return datos;
        }

        public Usuario GetByNickPassword(string nickname, string password)
        {
            var datos = _context.Usuario.Where(x => x.Nombre == nickname && x.Password == password).FirstOrDefault();

            return datos;
        }
        
    }
}
