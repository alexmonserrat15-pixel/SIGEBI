using SIGEBI.Web.Models.Dtos.Usuario;
using System.Text;
using System.Text.Json;

public class UsuarioService
{
    private readonly HttpClient _httpClient;

    public UsuarioService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("SIGEBI_API");
    }

    // 🔹 GET
    public async Task<List<UsuarioDto>> GetUsuarios()
    {
        var response = await _httpClient.GetAsync("api/Usuario");

        if (!response.IsSuccessStatusCode)
            return new List<UsuarioDto>();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<List<UsuarioDto>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    // 🔹 POST
    public async Task<bool> CrearUsuario(CreateUsuarioDto dto)
    {
        var json = JsonSerializer.Serialize(dto);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("api/Usuario", content);

        return response.IsSuccessStatusCode;
    }
}
