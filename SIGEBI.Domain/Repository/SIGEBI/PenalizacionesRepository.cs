
using SIGEBI.Domain.Entities.SIGEBI;

namespace SIGEBI.Domain.Repository.SIGEBI
{
    public interface IPenalizacionesRepository
    {
        Task<IEnumerable<Penalizaciones>> GetAllAsync();

        Task<IEnumerable<Penalizaciones>> GetByUsuarioIdAsync(int usuarioId);

        Task<Penalizaciones?> GetByIdAsync(int id);

        Task AddAsync(Penalizaciones penalizacion);

        Task UpdateAsync(Penalizaciones penalizacion);
    }
}
