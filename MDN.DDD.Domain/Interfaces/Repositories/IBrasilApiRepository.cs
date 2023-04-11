using MDN.DDD.Domain.Entities;

namespace MDN.DDD.Domain.Interfaces.Repositories
{
    public interface IBrasilApiRepository
    {
        Task<BrasilApi> GetEnderecoPorCepAsync(string cep);
    }
}
