using WebApi.Models;

namespace WebApi.Services
{
    public interface ICita
    {
        IEnumerable<Citum> GetAllCitas();
        IEnumerable<Citum> GetCitasUsu(int idusu);
        IEnumerable<Citum> GetCitasDoc(int idoc);

        void add(Citum cita);

        void CancelarCita(int id);
        void delete(int id);
    }
}
