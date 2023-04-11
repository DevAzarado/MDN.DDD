using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;

namespace MDN.DDD.Infrastructure.Repositories
{
    public class BrasilApiRepository : BaseApiRepository, IBrasilApiRepository
    {
        public BrasilApiRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<BrasilApi> GetEnderecoPorCepAsync(string cep)
        {
            return  await GetAsync<BrasilApi>($"https://brasilapi.com.br/api/cep/v1/{cep}");
        }
    }
}
