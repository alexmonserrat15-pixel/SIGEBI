using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Repository.SIGEBI.Base;

namespace SIGEBI.Domain.Interfaces.Repositories
{
    public interface IPrestamoRepository : IBaseRepository<Prestamos>
    {
        Task<IEnumerable<Prestamos>> GetAllAsync();

        Task<Prestamos?> GetByIdAsync(int id);

        Task<IEnumerable<Prestamos>> GetPrestamosByUsuario(int usuarioId);

        Task<IEnumerable<Prestamos>> GetPrestamosActivos();

        Task AddAsync(Prestamos prestamo);

        Task UpdateAsync(Prestamos prestamo);

        Task DeleteAsync(int id);
    }
}
