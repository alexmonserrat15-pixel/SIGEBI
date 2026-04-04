using SIGEBI.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    [Table("Notificaciones", Schema = "SIGEBI")]
    public sealed class Notificaciones 
    {
        [Key]
        public int IdNotificacion { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }

    }
}
