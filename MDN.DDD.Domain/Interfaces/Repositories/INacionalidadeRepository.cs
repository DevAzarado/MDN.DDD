using MDN.DDD.Domain.Entities;

namespace MDN.DDD.Domain.Interfaces.Repositories
{
    public interface INacionalidadeRepository
    {
        Task<Nacionalidade> GetNacionalidadeAsync(string nome);
    }
}
