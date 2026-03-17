using SIGEBI.Application.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos
{
  public class CreateUsuariodto: Usuariodto
    {
        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Rol { get; set; } = string.Empty;
    }
}
