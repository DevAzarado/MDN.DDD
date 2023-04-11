using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;
using MDN.DDD.Domain.Interfaces.Services;

namespace MDN.DDD.Domain.Services
{
    public class PerfilService : BaseService<Perfil>, IPerfilService
    {
        public PerfilService(IPerfilRepository repository) : base(repository)
        {
        }
    }
}
