using ProyectoFotoCore3.Repository.Context;
using ProyectoFotoCore3.Repository.Interfaces;
using System.Linq;

namespace ProyectoFotoCore3.Repository.Repositories
{
    public class RepositoryUser: IRepositoryUser
    {
        private readonly PictureManagerContext _context;
        public RepositoryUser(PictureManagerContext context)
        {
            _context = context;
        }

        public Users GetById(int id)
        {
            var datos = _context.Users.FirstOrDefault(x => x.Id == id.ToString());
            return datos;
        }

        public Users GetByNickPassword(string nickname, string password)
        {
            var datos = _context.Users.Where(x => x.Nick == nickname && x.Pwd == password).FirstOrDefault();

            return datos;
        }
        
    }
}
