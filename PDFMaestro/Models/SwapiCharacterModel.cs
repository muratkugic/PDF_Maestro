using System.Text.Json.Serialization;

namespace PDFMaestro.Models
{
    public class SwapiCharacterModel
    {
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }
        
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mass")]
        public string Weight { get; set; }
    }
}
