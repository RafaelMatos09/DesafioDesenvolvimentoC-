using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Models;
using PokeApi.Services.Regiao;
using PokeApi.Services.Tipo;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly RegiaoInterface _regiaoInterface;
        public RegiaoController(RegiaoInterface regiaoInterface)
        {
            _regiaoInterface = regiaoInterface;
        }

        [HttpGet("ListarRegioes")]
        public async Task<ActionResult<ResponseModel<List<RegiaoModel>>>> ListarRegioes()
        {
            var regioes = await _regiaoInterface.ListarRegioes();
            return Ok(regioes);
        }
    }
}
