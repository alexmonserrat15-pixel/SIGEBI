using Microsoft.EntityFrameworkCore;
using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Interfaces.Repositories;
using SIGEBI.Domain.Repository;
using SIGEBI.Infrastructure.Persistence;

namespace SIGEBI.Infrastructure.Persistence.Repositories
{
    public class GestionLibroRepository : IGestionLibroRepository
    {
        private readonly SIGEBIDbContext _context;

        public GestionLibroRepository(SIGEBIDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GestionLibros>> GetAllAsync()
        {
            return await _context.GestionLibros.ToListAsync();
        }

        public async Task<GestionLibros?> GetByIdAsync(int id)
        {
            return await _context.GestionLibros.FindAsync(id);
        }

        public async Task<IEnumerable<GestionLibros>> GetDisponiblesAsync()
        {
            return await _context.GestionLibros
                .Where(l => l.Estado == "Disponible")
                .ToListAsync();
        }

        public async Task AddAsync(GestionLibros libro)
        {
            await _context.GestionLibros.AddAsync(libro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(GestionLibros libro)
        {
            _context.GestionLibros.Update(libro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var libro = await _context.GestionLibros.FindAsync(id);

            if (libro != null)
            {
                _context.GestionLibros.Remove(libro);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.GestionLibros.AnyAsync(l => l.IdRecurso == id);
        }
    }
}