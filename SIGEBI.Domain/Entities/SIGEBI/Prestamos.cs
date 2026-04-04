using SIGEBI.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    [Table("Prestamos", Schema = "SIGEBI")]
    public sealed class Prestamos 
    {
        [Key]
        public int IdPrestamo { get; set; }
        public int IdRecurso { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios Usuario { get; set; }

        [ForeignKey("IdLibro")]
        public GestionLibros Libro { get; set; }

    }
}
