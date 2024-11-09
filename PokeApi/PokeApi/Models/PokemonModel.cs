using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string Pokemon { get; set; }
        public string tipo { get; set; }
        public string Status { get; set; }
        public string Fraquesas { get; set; }
        public string PontosFortes { get; set; }
        public int RegiaoId { get; set; }
        public RegiaoModel Regiao { get; set; } 
    }
}
