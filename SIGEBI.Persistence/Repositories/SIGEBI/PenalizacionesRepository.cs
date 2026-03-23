using Microsoft.EntityFrameworkCore;
using SIGEBI.Domain.Base;
using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Interfaces.Repositories;
using SIGEBI.Domain.Repository;
using SIGEBI.Domain.Repository.SIGEBI;
using SIGEBI.Infrastructure.Persistence;

namespace SIGEBI.Infrastructure.Persistence.Repositories
{
    public class PenalizacionRepository : IPenalizacionesRepository
    {
        private readonly SIGEBIDbContext _context;

        public PenalizacionRepository(SIGEBIDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Penalizaciones>> GetAllAsync()
        {
            return await _context.Penalizaciones.ToListAsync();
        }

        public async Task<Penalizaciones?> GetByIdAsync(int id)
        {
            return await _context.Penalizaciones.FindAsync(id);
        }

        public async Task<IEnumerable<Penalizaciones>> GetByUsuarioIdAsync(int usuarioId)
        {
            return await _context.Penalizaciones
                .Where(p => p.IdUsuario == usuarioId)
                .ToListAsync();
        }

        public async Task AddAsync(Penalizaciones penalizacion)
        {
            await _context.Penalizaciones.AddAsync(penalizacion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Penalizaciones penalizacion)
        {
            _context.Penalizaciones.Update(penalizacion);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var penalizacion = await _context.Penalizaciones.FindAsync(id);

            if (penalizacion != null)
            {
                _context.Penalizaciones.Remove(penalizacion);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<Penalizaciones>> IPenalizacionesRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Penalizaciones>> IPenalizacionesRepository.GetByUsuarioIdAsync(int usuarioId)
        {
            throw new NotImplementedException();
        }

        Task<Penalizaciones?> IPenalizacionesRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
