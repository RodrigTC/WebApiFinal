using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Services
{

    public class HorarioRepository : IHorarios
    {
        private ClinicaP conexion = new ClinicaP();
        public IEnumerable<Horario> GetAllHorarios()
        {
            return conexion.Horarios;
        }

        public Horario GetHorario(int id)
        {
            var obj = (from tusu in conexion.Horarios
                       where tusu.IdHorarios == id
                       select tusu).FirstOrDefault();
            return obj;
        }
    }
}
