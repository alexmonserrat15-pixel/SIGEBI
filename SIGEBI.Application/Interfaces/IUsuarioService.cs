using SIGEBI.Application.Dtos;
using SIGEBI.Application.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Interfaces
{
    public interface IUsuarioService 
    {
        Task<IEnumerable<Usuariodto>> GetAllUsuarios();

        Task<Usuariodto?> GetUsuarioById(int id);

        Task CrearUsuario(CreateUsuariodto dto);

        Task ActualizarUsuario(UpdateUsuarioDto dto);

        Task EliminarUsuario(DeleteUsuarioDto dto);
    }
}
