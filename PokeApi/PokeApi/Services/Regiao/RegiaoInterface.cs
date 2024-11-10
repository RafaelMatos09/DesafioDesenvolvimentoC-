using PokeApi.Models;

namespace PokeApi.Services.Regiao
{
    public interface RegiaoInterface
    {
        Task<ResponseModel<List<RegiaoModel>>> ListarRegioes();
    }
}
