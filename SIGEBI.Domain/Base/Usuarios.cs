
namespace SIGEBI.Domain.Base
{
    public abstract class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public int IdRol { get; set; }
        public string Estado { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
