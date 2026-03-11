using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Entities.SIGEBI;

namespace SIGEBI.Domain.Interfaces.Repositories
{
    public interface IPrestamoRepository
    {
        Task<IEnumerable<Prestamos>> GetAllAsync();

        Task<Prestamos?> GetByIdAsync(int id);

        Task<IEnumerable<Prestamos>> GetPrestamosByUsuario(int usuarioId);

        Task<IEnumerable<Prestamos>> GetPrestamosActivos();

        Task AddAsync(Prestamos prestamo);

        Task UpdateAsync(Prestamos prestamo);
    }
}
