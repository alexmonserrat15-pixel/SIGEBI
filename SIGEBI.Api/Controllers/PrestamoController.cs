using Microsoft.AspNetCore.Mvc;
using SIGEBI.Application.Dtos.Prestamo;
using SIGEBI.Application.Interfaces;

namespace SIGEBI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrestamoController : ControllerBase
    {
        private readonly IPrestamoService _service;

        public PrestamoController(IPrestamoService service)
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
            var prestamo = await _service.GetById(id);

            if (prestamo == null)
                return NotFound("Prestamo no encontrado");

            return Ok(prestamo);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CreatePrestamoDto dto)
        {
            await _service.Crear(dto);
            return Ok("Prestamo creado");
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(UpdatePrestamoDto dto)
        {
            await _service.Actualizar(dto);
            return Ok("Prestamo actualizado");
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(DeletePrestamoDto dto)
        {
            await _service.Eliminar(dto);
            return Ok("Prestamo eliminado");
        }
    }
}
