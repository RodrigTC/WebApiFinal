using WebApi.Models;

namespace WebApi.Services
{
    public interface IDoctor
    {
        IEnumerable<Doctor> GetAllDoctores();
        Doctor GetDoctor(int id);
        void add(Doctor doc);
        void update(Doctor doc);
        void delete(int id);
        Doctor GetDoctorByEmail(string email);
        IEnumerable<Doctor> GetDoctorByEspecialidad(int id);
    }
}
