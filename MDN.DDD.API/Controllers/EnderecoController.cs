using MDN.DDD.Domain.Contracts.Requests;
using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Services;
using MDN.DDD.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MDN.DDD.API.Controllers
{
    public class EnderecoController : BaseController<Endereco, EnderecoRequest, EnderecoResponse>
    {

        private readonly IMapper _mapper;
        private readonly IEnderecoService _enderecoService;
        public EnderecoController(IMapper mapper, IEnderecoService enderecoService) : base(mapper, enderecoService)
        {
            _mapper = mapper;
            _enderecoService = enderecoService;
        }

        [HttpGet("cep")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<BrasilApiResponse>> GetNacionalidadeAsync([FromQuery] string cep)
        {
            var entity = await _enderecoService.ObterEnderecoPorCepAsync(cep);
            var response = _mapper.Map<BrasilApiResponse>(entity);

            return Ok(response);
        }
    }
}
