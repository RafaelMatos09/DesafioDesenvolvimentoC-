using PokeApi.Models;

namespace PokeApi.Services.Tipo
{
    public interface PokemonInterface
    {
        Task<ResponseModel<List<PokemonModel>>> ListarPokemons();
        Task<ResponseModel<List<PokemonModel>>> BuscarPokemonPorRegiao(int idRegiao);       
        

    }
}
