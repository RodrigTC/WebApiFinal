using WebApi.Models;

namespace WebApi.Services
{
    public class DoctorRepository :IDoctor
    {
        private ClinicaP conexion = new ClinicaP();

        private List<Doctor> lste = new List<Doctor>();

        public void add(Doctor doc)
        {
            conexion.Doctors.Add(doc);
            conexion.SaveChanges();
        }

        public void delete(int id)
        {
            var obj = (from tco in conexion.Doctors
                       where tco.IdDoctor == id
                       select tco).FirstOrDefault();
        }

        public IEnumerable<Doctor> GetAllDoctores()
        {
            return conexion.Doctors;
        }

        public Doctor GetDoctor(int id)
        {
            var obj = (from tusu in conexion.Doctors
                       where tusu.IdDoctor == id
                       select tusu).FirstOrDefault();
            return obj;
        }

        public Doctor GetDoctorByEmail(string email)
        {
            var obj = (from tcorreo in conexion.Doctors
                        where tcorreo.CorreoD==email
                        select tcorreo).FirstOrDefault();
            return obj;
        }

        public IEnumerable<Doctor> GetDoctorByEspecialidad(int id)
        {
            lste.Clear();
            for (int i = 0; i < conexion.Doctors.LongCount(); i++)
            {
                var obj = (from tesp in conexion.Doctors
                           where tesp.IdEspecialidad == id
                           select tesp).FirstOrDefault();
                lste.Add(obj);

            }
            return lste; 
        }

        public void update(Doctor doc)
        {
            throw new NotImplementedException();
        }
    }
}
