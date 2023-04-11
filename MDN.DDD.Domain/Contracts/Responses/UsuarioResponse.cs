namespace MDN.DDD.Domain.Contracts.Responses
{
    public class UsuarioResponse : BaseResponse
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public PerfilResponse Perfil { get; set; }
    }
}

