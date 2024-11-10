using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Models;
using PokeApi.Services.Tipo;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonInterface _pokemonInterface;
        public PokemonController(PokemonInterface pokemonInterface) 
        {
            _pokemonInterface = pokemonInterface;
        }

        [HttpGet("ListarPokemons")]
        public async Task<ActionResult<ResponseModel<List<PokemonModel>>>> ListarPokemons()
        {
            var pokemons = await _pokemonInterface.ListarPokemons();
            return Ok(pokemons);
        }

        [HttpGet("BuscarPokemonPorRegiao/{idRegiao}")]
        public async Task<ActionResult<ResponseModel<RegiaoModel>>> BuscarPokemonPorRegiao(int idRegiao)
        {
            var regiao = await _pokemonInterface.BuscarPokemonPorRegiao(idRegiao);
            return Ok(regiao);
        }
    }
}
