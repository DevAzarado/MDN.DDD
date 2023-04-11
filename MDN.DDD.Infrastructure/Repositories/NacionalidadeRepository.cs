using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;

namespace MDN.DDD.Infrastructure.Repositories
{
    public class NacionalidadeRepository : BaseApiRepository, INacionalidadeRepository
    {
        public NacionalidadeRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Nacionalidade> GetNacionalidadeAsync(string nome)
        {
            return await GetAsync<Nacionalidade>($"/?name={nome}");
        }
    }
}
