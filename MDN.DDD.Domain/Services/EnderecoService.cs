using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;
using MDN.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDN.DDD.Domain.Services
{

    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {

        private readonly IBrasilApiRepository _brasilApiRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository, IBrasilApiRepository brasilApiRepository) : base(enderecoRepository)
        {
            _brasilApiRepository = brasilApiRepository;
        }

        public Task<BrasilApi> ObterEnderecoPorCepAsync(string cep)
        {
            return _brasilApiRepository.GetEnderecoPorCepAsync(cep);
        }
    }
}
