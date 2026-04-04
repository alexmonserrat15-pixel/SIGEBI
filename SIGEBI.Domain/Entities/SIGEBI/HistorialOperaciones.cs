using SIGEBI.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    [Table("HistorialOperaciones", Schema = "SIGEBI")]
    public sealed class HistorialOperaciones : Usuarios
    {
        [Key]
        public int IdHistorial { get; set; }
        public int IdUsuario { get; set; }
        public string TipoOperacion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string? IpOrigen { get; set; }
    }
}
