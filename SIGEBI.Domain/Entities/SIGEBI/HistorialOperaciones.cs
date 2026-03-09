using SIGEBI.Domain.Base;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class HistorialOperaciones : Usuarios
    {
        public int IdHistorial { get; set; }
        public int IdUsuario { get; set; }
        public string TipoOperacion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string? IpOrigen { get; set; }
    }
}
