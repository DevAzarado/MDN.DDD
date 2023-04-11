using MDN.DDD.Infrastructure.Contexts;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;

namespace MDN.DDD.Infrastructure.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(ManutencaoContext manutencaoContext) : base(manutencaoContext)
        {
        }
    }
}
