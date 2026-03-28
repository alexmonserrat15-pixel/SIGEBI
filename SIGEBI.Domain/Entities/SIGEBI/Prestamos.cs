using SIGEBI.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class Prestamos 
    {
        [Key]
        public int IdPrestamo { get; set; }
        public int IdRecurso { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }

    }
}
