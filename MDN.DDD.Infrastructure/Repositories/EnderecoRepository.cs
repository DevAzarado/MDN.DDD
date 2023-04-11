using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;
using MDN.DDD.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDN.DDD.Infrastructure.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ManutencaoContext manutencaoContext) : base(manutencaoContext)
        {

        }
    }
}
