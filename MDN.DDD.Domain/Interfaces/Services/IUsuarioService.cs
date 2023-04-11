using MDN.DDD.Domain.Entities;

namespace MDN.DDD.Domain.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Task CriarUsuarioAsync(Usuario usuario);
        Task AtualizarUsuarioAsync(Usuario usuario);
        Task<Nacionalidade> ObterNacionalidadeAsync(string nome);
    }
}
