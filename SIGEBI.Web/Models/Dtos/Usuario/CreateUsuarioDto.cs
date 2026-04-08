namespace SIGEBI.Web.Models.Dtos.Usuario
{
    public class CreateUsuarioDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
    }
}
