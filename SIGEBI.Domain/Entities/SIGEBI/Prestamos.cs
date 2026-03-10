using SIGEBI.Domain.Base;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class Prestamos : Usuarios
    {
        public int IdPrestamo { get; set; }
        public int IdRecurso { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }

    }
}
