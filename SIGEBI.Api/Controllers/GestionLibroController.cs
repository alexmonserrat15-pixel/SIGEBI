using Microsoft.AspNetCore.Mvc;
using SIGEBI.Application.Dtos.GestionLibros;
using SIGEBI.Application.Interfaces;

namespace SIGEBI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GestionLibroController : ControllerBase
    {
        private readonly IGestionLibroService _service;

        public GestionLibroController(IGestionLibroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var libro = await _service.GetById(id);

            if (libro == null)
                return NotFound("Libro no encontrado");

            return Ok(libro);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CreateGestionLibrodto dto)
        {
            await _service.Crear(dto);
            return Ok("Libro creado");
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(UpdateGestionLibroDto dto)
        {
            await _service.Actualizar(dto);
            return Ok("Libro actualizado");
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(DeleteGestionLibroDto dto)
        {
            await _service.Eliminar(dto);
            return Ok("Libro eliminado");
        }
    }
}
