using WebApi.Models;
namespace WebApi.Services
{
    public class EspecialidadRepository :IEspecialidad
    {
        private ClinicaP conexion = new ClinicaP();

        public IEnumerable<Especialidad> GetAllEspecialidades()
        {
            return conexion.Especialidads;
        }
         
        public Especialidad GetEspecialidad(int id)
        {
            var obj = (from tusu in conexion.Especialidads
                       where tusu.IdEspecialidad == id
                       select tusu).Single();
            return obj;
        }
    }
}
