using SIGEBI.Web.Models.Dtos.GestionLibros;
using System.Text;
using System.Text.Json;

namespace SIGEBI.Web.Services
{
    public class GestionLibrosService
    {

        private readonly HttpClient _httpClient;

        // 🔥 Inyección correcta
        public GestionLibrosService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("SIGEBI_API");
        }
        public async Task<bool> CrearLibro(CreateLibroDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/GestionLibro", content);

            return response.IsSuccessStatusCode;
        }
    }
}
