using Microsoft.AspNetCore.Mvc;
using SIGEBI.Application.Dtos.Penalizacion;
using SIGEBI.Application.Interfaces;
using static SIGEBI.Application.Dtos.Penalizacion.CreatePenalizaciondto;
using static SIGEBI.Application.Dtos.Penalizacion.DeletePenalizaciondto;

namespace SIGEBI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PenalizacionController : ControllerBase
    {
        private readonly IPenalizacionService _service;

        public PenalizacionController(IPenalizacionService service)
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
            var penalizacion = await _service.GetById(id);

            if (penalizacion == null)
                return NotFound("Penalizacion no encontrada");

            return Ok(penalizacion);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CreatePenalizacionDto dto)
        {
            await _service.Crear(dto);
            return Ok("Penalizacion creada");
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(UpdatePenalizacionDto dto)
        {
            await _service.Actualizar(dto);
            return Ok("Penalizacion actualizada");
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(DeletePenalizacionDto dto)
        {
            await _service.Eliminar(dto);
            return Ok("Penalizacion eliminada");
        }
    }
}
