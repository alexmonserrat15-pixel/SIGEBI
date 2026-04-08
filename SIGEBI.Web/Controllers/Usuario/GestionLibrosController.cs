using Microsoft.AspNetCore.Mvc;
using SIGEBI.Web.Models.Dtos.GestionLibros;

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
