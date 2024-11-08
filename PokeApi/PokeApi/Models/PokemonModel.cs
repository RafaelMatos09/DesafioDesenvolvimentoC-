using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Status { get; set; }
        public string Fraquesas { get; set; }
        public string PontosFortes { get; set; }
        [JsonIgnore]
        public ICollection<TipoModel> Tipo {  get; set; }
    }
}
