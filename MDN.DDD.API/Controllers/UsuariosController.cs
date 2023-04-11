using MDN.DDD.Domain.Contracts.Requests;
using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MDN.DDD.API.Controllers
{
    public class UsuariosController : BaseController<Usuario, UsuarioRequest, UsuarioResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IMapper mapper, IUsuarioService service) : base(mapper, service)
        {
            _mapper = mapper;
            _usuarioService = service;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public override async Task<ActionResult> PostAsync([FromBody] UsuarioRequest request)
        {
            var entity = _mapper.Map<Usuario>(request);
            await _usuarioService.CriarUsuarioAsync(entity);
            return Created(nameof(PostAsync), new { id = entity.Id });
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        public override async Task<ActionResult> PutAsync([FromRoute] int id, [FromBody] UsuarioRequest request)
        {
            var entity = _mapper.Map<Usuario>(request);
            entity.Id = id;
           await _usuarioService.AtualizarUsuarioAsync(entity);
           return NoContent();
            
        }

        [HttpGet("nacionalidade")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<NacionalidadeResponse>> GetNacionalidadeAsync([FromQuery] string nome)
        {
            var entity = await _usuarioService.ObterNacionalidadeAsync(nome);
            var response = _mapper.Map<NacionalidadeResponse>(entity);
            return Ok(response);
        }
    }
}
