using WebApi.Models;
namespace WebApi.Services
{
    public interface IEspecialidad
    {
        IEnumerable<Especialidad> GetAllEspecialidades();
        Especialidad GetEspecialidad(int id);

    }
}
