using PDFMaestro.Models;
using PDFMaestro.Services.Interfaces;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PDFMaestro.Services
{
    public class SwapiService : ISwapiService
    {
        public SwapiCharacterModel SwapiCharacter { get; private set; }

        private readonly IHttpClientFactory _httpClientFactory;

        public SwapiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<SwapiCharacterModel> GetSwapiCharacter(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            $"http://swapi.dev/api/people/{id}/");
            request.Headers.Add("Accept", "application/json");

            var client = _httpClientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();
            SwapiCharacter = await JsonSerializer.DeserializeAsync
                <SwapiCharacterModel>(responseStream);

            return SwapiCharacter;
        }
    }
}
