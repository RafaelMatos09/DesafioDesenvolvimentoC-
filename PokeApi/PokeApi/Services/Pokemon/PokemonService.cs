using Microsoft.EntityFrameworkCore;
using PokeApi.Data;
using PokeApi.Models;

namespace PokeApi.Services.Tipo
{
    public class PokemonService : PokemonInterface
    {
        private readonly AppDbContext _context;
        public PokemonService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<List<PokemonModel>>> BuscarPokemonPorRegiao(int idRegiao)
        {
            ResponseModel<List<PokemonModel>> resposta = new ResponseModel<List<PokemonModel>>();

            try
            {
                
                var pokemons = await _context.Pokemons
                    .Where(p => p.RegiaoId == idRegiao)
                    .Include(p => p.Regiao)
                    .ToListAsync();

                if (pokemons == null || !pokemons.Any())
                {
                    resposta.Mensagem = "Nenhum Pokémon encontrado para esta região!";
                    resposta.Status = false;
                    return resposta;
                }

                resposta.Dados = pokemons;  
                resposta.Mensagem = "Pokémons encontrados!";
                resposta.Status = true;

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<PokemonModel>>> ListarPokemons()
        {
            ResponseModel<List<PokemonModel>> resposta = new ResponseModel<List<PokemonModel>>();

            try
            {
                
                var pokemons = await _context.Pokemons
                    .Include(p => p.Regiao)
                    .ToListAsync();

                if (pokemons == null || !pokemons.Any())
                {
                    resposta.Mensagem = "Nenhum Pokémon encontrado!";
                    resposta.Status = false;
                    return resposta;
                }

                resposta.Dados = pokemons;  
                resposta.Mensagem = "Pokémons encontrados!";
                resposta.Status = true;

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }




    }
}
