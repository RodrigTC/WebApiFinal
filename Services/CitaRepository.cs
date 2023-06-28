using WebApi.Models;

namespace WebApi.Services
{
    public class CitaRepository : ICita
    {
        private ClinicaP conexion = new ClinicaP();
        private List<Citum> lstd = new List<Citum>();
        private List<Citum> lstc = new List<Citum>();
        public void add(Citum cita)
        {
            conexion.Cita.Add(cita);
            conexion.SaveChanges();
        }

        public void CancelarCita(int id)
        {
            var obj = (from tusu in conexion.Usuarios
                       where tusu.IdUser == id
                       select tusu).Single();
            conexion.Usuarios.Remove(obj);
            conexion.SaveChanges();
        }

        public void delete(int id)
        {
            var obj = (from tcitum in conexion.Cita
                       where tcitum.IdCita == id
                       select tcitum).Single();
            conexion.Cita.Remove(obj);
            conexion.SaveChanges();
        }

        public IEnumerable<Citum> GetAllCitas()
        {
            return conexion.Cita;
        }

        public IEnumerable<Citum> GetCitasDoc(int idoc)
        {

            var obj = (from tdoc in conexion.Cita
                       where tdoc.IdDoctor == idoc
                       select tdoc).FirstOrDefault();
            lstd.Add(obj);

            return lstd;
        }

        public IEnumerable<Citum> GetCitasUsu(int idusu)
        {
            var obj = (from tusu in conexion.Cita
                       where tusu.IdUser == idusu
                       select tusu).FirstOrDefault();
            lstc.Add(obj);

            return lstc;
        }
    }
}
