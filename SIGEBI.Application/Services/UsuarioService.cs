using SIGEBI.Application.Dtos;
using SIGEBI.Application.Dtos.Usuario;
using SIGEBI.Application.Interfaces;
using SIGEBI.Domain.Base;
using SIGEBI.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllUsuarios()
        {
            var usuarios = await _usuarioRepository.GetAllAsync();

            return usuarios.Select(u => new UsuarioDto
            {
                IdUsuario = u.IdUsuario,
                Nombre = u.Nombre,
                Email = u.Email,
                Rol = u.Rol,
                Activo = u.Activo
            });
        }

        public async Task<UsuarioDto?> GetUsuarioById(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);

            if (usuario == null)
                return null;

            return new UsuarioDto
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Email = usuario.Email,
                Rol = usuario.Rol,
                Activo = usuario.Activo
            };
        }

        public async Task CrearUsuario(CreateUsuarioDto dto)
        {
            var usuario = new Usuario
            {
                Nombre = dto.Nombre,
                Email = dto.Email,
                PasswordHash = dto.Password, 
                Rol = dto.Rol,
                Activo = true
            };

            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task ActualizarUsuario(UpdateUsuarioDto dto)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(dto.IdUsuario);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            usuario.Nombre = dto.Nombre;
            usuario.Email = dto.Email;
            usuario.Rol = dto.Rol;
            usuario.Activo = dto.Activo;

            await _usuarioRepository.UpdateAsync(usuario);
        }

        public async Task EliminarUsuario(DeleteUsuarioDto dto)
        {
            await _usuarioRepository.DeleteAsync(dto.IdUsuario);
        }
    }
}
