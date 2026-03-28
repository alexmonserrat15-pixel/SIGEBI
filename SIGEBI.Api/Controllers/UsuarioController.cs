using Microsoft.AspNetCore.Mvc;
using SIGEBI.Application.Dtos;
using SIGEBI.Application.Dtos.Usuario;
using SIGEBI.Application.Interfaces;

namespace SIGEBI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _service.GetAllUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _service.GetUsuarioById(id);

            if (usuario == null)
                return NotFound("Usuario no encontrado");

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] CreateUsuariodto dto)
        {
            await _service.CrearUsuario(dto);
            return Ok("Usuario creado correctamente");
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar([FromBody] UpdateUsuarioDto dto)
        {
            await _service.ActualizarUsuario(dto);
            return Ok("Usuario actualizado");
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar([FromBody] DeleteUsuarioDto dto)
        {
            await _service.EliminarUsuario(dto);
            return Ok("Usuario eliminado");
        }
    }
}
