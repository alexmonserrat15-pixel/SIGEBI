using SIGEBI.Application.Dtos;
using SIGEBI.Application.Dtos.Usuario;
using SIGEBI.Application.Interfaces;
using SIGEBI.Domain.Base;
using SIGEBI.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SIGEBI.Domain.Entities;


namespace SIGEBI.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<Usuariodto>> GetAllUsuarios()
        {
            var usuarios = await _usuarioRepository.GetAllAsync();

            return usuarios.Select(u => new Usuariodto
            {
                IdUsuario = u.IdUsuario,
                Nombre = u.Nombre,
                Email = u.Email,
                IdRol = u.IdRol,
                Estado = u.Estado
            });
        }

        public async Task<Usuariodto?> GetUsuarioById(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);

            if (usuario == null)
                return null;

            return new Usuariodto
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Email = usuario.Email,
                IdRol = usuario.IdRol,
                Estado = usuario.Estado
            };
        }

        public async Task CrearUsuario(CreateUsuariodto dto)
        {
            var usuario = new Usuarios
            {
                Nombre = dto.Nombre,
                Email = dto.Email,
                Password = dto.Password, 
                IdRol = dto.IdRol,
                Estado = dto.Estado
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
            usuario.IdRol = dto.IdRol;
            usuario.Estado = dto.Estado;

            await _usuarioRepository.UpdateAsync(usuario);
        }

        public async Task EliminarUsuario(DeleteUsuarioDto dto)
        {
            await _usuarioRepository.DeleteAsync(dto.IdUsuario);
        }
    }
}
