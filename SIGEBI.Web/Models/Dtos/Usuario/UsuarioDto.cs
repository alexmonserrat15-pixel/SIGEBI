namespace SIGEBI.Web.Models.Dtos.Usuario
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
        public string Estado { get; set; }
    }
}
