using MDN.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDN.DDD.Domain.Interfaces.Services
{
    public interface IEnderecoService : IBaseService<Endereco>
    {
        Task<BrasilApi> ObterEnderecoPorCepAsync(string cep);
    }
}
