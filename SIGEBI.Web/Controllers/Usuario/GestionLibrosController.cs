using Microsoft.AspNetCore.Mvc;
using SIGEBI.Web.Models.Dtos;
using SIGEBI.Web.Models.Dtos.GestionLibros;
using SIGEBI.Web.Models.Dtos.Usuario;
using SIGEBI.Web.Services;

namespace SIGEBI.Web.Controllers.Usuario
{
    public class GestionLibrosController : Controller
    {
        private readonly GestionLibrosService _service;

        public GestionLibrosController(GestionLibrosService service)
        {
            _service = service;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLibroDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var result = await _service.CrearLibro(dto);

            if (!result)
            {
                ModelState.AddModelError("", "Error al crear libro");
                return View(dto);
            }

            return RedirectToAction("Index");
        }
    }
}
