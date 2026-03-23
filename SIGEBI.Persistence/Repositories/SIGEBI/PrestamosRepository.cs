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
    public class PrestamoRepository : IPrestamoRepository
    {
        private readonly SIGEBIDbContext _context;

        public PrestamoRepository(SIGEBIDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Prestamos>> GetAllAsync()
        {
            return await _context.Prestamos
                .Include(p => p.IdUsuario)
                .Include(p => p.IdRecurso)
                .ToListAsync();
        }

        public async Task<Prestamos?> GetByIdAsync(int id)
        {
            return await _context.Prestamos
                .Include(p => p.IdUsuario)
                .Include(p => p.IdRecurso)
                .FirstOrDefaultAsync(p => p.IdPrestamo == id);
        }

        public async Task<IEnumerable<Prestamos>> GetPrestamosActivosAsync()
        {
            return await _context.Prestamos
                .Where(p => p.Estado == "Activo")
                .ToListAsync();
        }

        public async Task<IEnumerable<Prestamos>> GetPrestamosByUsuarioAsync(int usuarioId)
        {
            return await _context.Prestamos
                .Where(p => p.IdUsuario == usuarioId)
                .ToListAsync();
        }

        public async Task AddAsync(Prestamos prestamo)
        {
            await _context.Prestamos.AddAsync(prestamo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Prestamos prestamo)
        {
            _context.Prestamos.Update(prestamo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo != null)
            {
                _context.Prestamos.Remove(prestamo);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<Prestamos>> IPrestamoRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Prestamos?> IPrestamoRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Prestamos>> GetPrestamosByUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Prestamos>> GetPrestamosActivos()
        {
            throw new NotImplementedException();
        }

    }
}