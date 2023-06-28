using WebApi.Models;

namespace WebApi.Services
{
    public interface IDia
    {
        IEnumerable<Dium> GetAllDias();
        Dium GetDiumById(int id);
    }
}
