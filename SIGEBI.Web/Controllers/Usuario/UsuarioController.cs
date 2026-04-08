using Microsoft.AspNetCore.Mvc;
using SIGEBI.Web.Models.Dtos.Usuario;
using SIGEBI.Web.Models.Dtos;
public class UsuarioController : Controller
{
    private readonly UsuarioService _service;

    public UsuarioController(UsuarioService service)
    {
        _service = service;
    }

    // 🔹 GET
    public async Task<IActionResult> Index()
    {
        var usuarios = await _service.GetUsuarios();
        return View(usuarios);
    }

    // 🔹 FORM
    public IActionResult Create()
    {
        return View();
    }

    // 🔹 POST
    [HttpPost]
    public async Task<IActionResult> Create(CreateUsuarioDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var result = await _service.CrearUsuario(dto);

        if (!result)
        {
            ModelState.AddModelError("", "Error al crear usuario");
            return View(dto);
        }

        return RedirectToAction("Index");
    }
}
