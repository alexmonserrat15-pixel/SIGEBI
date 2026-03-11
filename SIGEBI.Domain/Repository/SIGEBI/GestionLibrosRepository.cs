using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Repository.SIGEBI.Base;

namespace SIGEBI.Domain.Interfaces.Repositories
{
    public interface IGestionLibroRepository : IBaseRepository<GestionLibros>
    {
        Task<IEnumerable<GestionLibros>> GetAllAsync();

        Task<GestionLibros?> GetByIdAsync(int id);

        Task<IEnumerable<GestionLibros>> GetDisponiblesAsync();

        Task AddAsync(GestionLibros libro);

        Task UpdateAsync(GestionLibros libro);

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}
