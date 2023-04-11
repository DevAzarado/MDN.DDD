using MDN.DDD.Infrastructure.Contexts;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;

namespace MDN.DDD.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ManutencaoContext manutencaoContext) : base(manutencaoContext)
        {
        }
    }
}
