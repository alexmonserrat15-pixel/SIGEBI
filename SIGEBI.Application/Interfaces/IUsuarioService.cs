using SIGEBI.Application.Dtos;
using SIGEBI.Application.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Interfaces
{
    public interface IUsuarioService 
    {
        Task<IEnumerable<UsuarioDto>> GetAllUsuarios();

        Task<UsuarioDto?> GetUsuarioById(int id);

        Task CrearUsuario(CreateUsuarioDto dto);

        Task ActualizarUsuario(UpdateUsuarioDto dto);

        Task EliminarUsuario(DeleteUsuarioDto dto);
    }
}
