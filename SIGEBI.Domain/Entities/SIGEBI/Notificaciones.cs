using SIGEBI.Domain.Base;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class Notificaciones 
    {
        public int IdNotificacion { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }

    }
}
