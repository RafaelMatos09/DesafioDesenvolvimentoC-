using Microsoft.EntityFrameworkCore;
using PokeApi.Data;
using PokeApi.Models;

namespace PokeApi.Services.Regiao
{


    public class RegiaoService : RegiaoInterface
    {
        private readonly AppDbContext _context;
        public RegiaoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<RegiaoModel>>> ListarRegioes()
        {
            ResponseModel<List<RegiaoModel>> resposta = new ResponseModel<List<RegiaoModel>>();

            try
            {

                var regioes = await _context.Regioes                    
                    .ToListAsync();

                if (regioes == null || !regioes.Any())
                {
                    resposta.Mensagem = "Nenhum Pokémon encontrado!";
                    resposta.Status = false;
                    return resposta;
                }

                resposta.Dados = regioes;
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
