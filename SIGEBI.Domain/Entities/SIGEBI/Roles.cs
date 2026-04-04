using SIGEBI.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    [Table("Roles", Schema = "SIGEBI")]
    public sealed class Roles : Usuarios
    {
        public string NombreRol { get; set; }
    }
}
