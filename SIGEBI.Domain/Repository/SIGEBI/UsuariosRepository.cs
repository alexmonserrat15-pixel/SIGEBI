using SIGEBI.Domain.Base;
using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Repository.SIGEBI.Base;

namespace SIGEBI.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuarios>
    {
        Task<IEnumerable<Usuarios>> GetAllAsync();

        Task<Usuarios?> GetByIdAsync(int id);

        Task<Usuarios?> GetByEmailAsync(string email);

        Task AddAsync(Usuarios usuario);

        Task UpdateAsync(Usuarios usuario);

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}