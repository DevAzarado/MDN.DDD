using MDN.DDD.Domain.Contracts.Requests;
using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Services;
using AutoMapper;

namespace MDN.DDD.API.Controllers
{
    public class PerfisController : BaseController<Perfil, PerfilRequest, PerfilResponse>
    {
        public PerfisController(IMapper mapper, IPerfilService perfilService) : base(mapper, perfilService)
        {
        }
    }
}
