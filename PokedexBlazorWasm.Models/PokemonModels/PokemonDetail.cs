using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokedexBlazorWasm.Models.PokemonModels
{
    public class PokemonDetail
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

                [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("base_experience")]
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }
        
        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("types")]
        public List<string>? Type { get; set; }
    }
}