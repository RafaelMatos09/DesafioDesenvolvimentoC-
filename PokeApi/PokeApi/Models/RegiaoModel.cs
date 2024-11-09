using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class RegiaoModel
    {
        public int Id { get; set; }
        public string Regiao { get; set; }
        [JsonIgnore]
        public ICollection<PokemonModel> Pokemon { get; set; }

    }
}
