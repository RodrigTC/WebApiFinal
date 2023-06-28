using WebApi.Models;

namespace WebApi.Services
{
    public class DiaRepository :IDia
    {
        private ClinicaP conexion = new ClinicaP();

        public IEnumerable<Dium> GetAllDias()
        {
            return conexion.Dia;
        }

        public Dium GetDiumById(int id)
        {
            var obj = (from tdia in conexion.Dia
                       where tdia.IdDia == id
                       select tdia).FirstOrDefault();
            return obj;
        }
    }
}
