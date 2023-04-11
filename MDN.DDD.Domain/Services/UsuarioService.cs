using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Enums;
using MDN.DDD.Domain.Exceptions;
using MDN.DDD.Domain.Interfaces.Repositories;
using MDN.DDD.Domain.Interfaces.Services;

namespace MDN.DDD.Domain.Services

{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly INacionalidadeRepository _nacionalidadeRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository,
            INacionalidadeRepository nacionalidadeRepository) : base(usuarioRepository)
        {
            _nacionalidadeRepository = nacionalidadeRepository;
        }

        public async Task CriarUsuarioAsync(Usuario usuario)
        {
          usuario.EstaConsistente();


            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha, BCrypt.Net.BCrypt.GenerateSalt());
            await AdicionarAsync(usuario);
        }

        public async Task AtualizarUsuarioAsync(Usuario usuario)
        {
            usuario.EstaConsistente();
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha, BCrypt.Net.BCrypt.GenerateSalt());
            await AlterarAsync(usuario);
        }

        public async Task<Nacionalidade> ObterNacionalidadeAsync(string nome)
        {
            return await _nacionalidadeRepository.GetNacionalidadeAsync(nome);
        }
       
    }
}
