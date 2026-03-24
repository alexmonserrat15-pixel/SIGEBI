using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Usuario
{
    public class UpdateUsuarioDto
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string IdRol { get; set; } = string.Empty;

        public bool Estado { get; set; }
    }
}
