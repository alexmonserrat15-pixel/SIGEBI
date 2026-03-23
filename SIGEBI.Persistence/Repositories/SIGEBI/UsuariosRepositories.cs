using Microsoft.EntityFrameworkCore;
using SIGEBI.Domain.Base;
using SIGEBI.Domain.Entities;
using SIGEBI.Domain.Interfaces.Repositories;
using SIGEBI.Domain.Repository;
using SIGEBI.Infrastructure.Persistence;

namespace SIGEBI.Persistence.Repositories.SIGEBI
{
    public class UsuariosRepositories : IUsuarioRepository
    {
        public Task AddAsync(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuarios>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios?> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly SIGEBIDbContext _context;

            public UsuarioRepository(SIGEBIDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Usuarios>> GetAllAsync()
            {
                return await _context.Usuarios.ToListAsync();
            }

            public async Task<Usuarios?> GetByIdAsync(int id)
            {
                return await _context.Usuarios.FindAsync(id);
            }

            public async Task<Usuarios?> GetByEmailAsync(string email)
            {
                return await _context.Usuarios
                    .FirstOrDefaultAsync(u => u.Email == email);
            }

            public async Task AddAsync(Usuarios usuario)
            {
                await _context.Usuarios.AddAsync(usuario);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Usuarios usuario)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var usuario = await _context.Usuarios.FindAsync(id);

                if (usuario != null)
                {
                    _context.Usuarios.Remove(usuario);
                    await _context.SaveChangesAsync();
                }
            }

            public async Task<bool> ExistsAsync(int id)
            {
                return await _context.Usuarios.AnyAsync(u => u.IdUsuario == id);
            }
        }
}
}