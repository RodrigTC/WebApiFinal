using WebApi.Models;

namespace WebApi.Services
{
    public interface IUsuario
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetUsuario(int id);
        void add(Usuario producto);
        void update(Usuario producto);
        void delete(int id);

    }
}
