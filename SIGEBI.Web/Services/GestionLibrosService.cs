using SIGEBI.Web.Models.Dtos.GestionLibros;
using System.Text;
using System.Text.Json;

public async Task<bool> CrearLibro(CreateLibroDto dto)
{
    var json = JsonSerializer.Serialize(dto);
    var content = new StringContent(json, Encoding.UTF8, "application/json");

    var response = await _httpClient.PostAsync("api/GestionLibro", content);

    return response.IsSuccessStatusCode;
}
