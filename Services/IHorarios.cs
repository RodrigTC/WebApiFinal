using WebApi.Models;

namespace WebApi.Services
{
    public interface IHorarios
    {
        IEnumerable<Horario> GetAllHorarios();
        Horario GetHorario(int id);
        //void add(Usuario producto);
        //void update(Usuario producto);
        //void delete(int id);
    }
}
