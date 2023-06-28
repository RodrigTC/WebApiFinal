using WebApi.Models;

namespace WebApi.Services
{
    public class UsuarioRepository: IUsuario
    {
        private ClinicaP conexion = new ClinicaP();

        public void add(Usuario usuario)
        {
            conexion.Usuarios.Add(usuario);
            conexion.SaveChanges();
        }

        public void delete(int id)
        {
            var obj = (from tusu in conexion.Usuarios
                       where tusu.IdUser == id
                       select tusu).Single();
            conexion.Usuarios.Remove(obj);
            conexion.SaveChanges();
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return conexion.Usuarios;
        }

        public Usuario GetUsuario(int id)
        {
            var obj = (from tusu in conexion.Usuarios
                       where tusu.IdUser == id
                       select tusu).Single();
            return obj;
        }

        public void update(Usuario obj)
        {
            var objAModificar = (from tusu in conexion.Usuarios
                                 where tusu.IdUser == obj.IdUser
                                 select tusu).FirstOrDefault();
            objAModificar.Nombreu = obj.Nombreu;
            objAModificar.Apellidou = obj.Apellidou;
            objAModificar.Correou = obj.Correou;
            objAModificar.Telefono = obj.Telefono;
            conexion.SaveChanges();
        }
    }
}
