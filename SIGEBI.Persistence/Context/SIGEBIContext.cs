using Microsoft.EntityFrameworkCore;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Base

namespace SIGEBI.Infrastructure.Persistence
{
    public class SIGEBIDbContext : DbContext
    {
        public SIGEBIDbContext(DbContextOptions<SIGEBIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<GestionLibros> GestionLibros { get; set; }

        public DbSet<Prestamos> Prestamos { get; set; }

        public DbSet<Penalizaciones> Penalizaciones { get; set; }

    }
}
