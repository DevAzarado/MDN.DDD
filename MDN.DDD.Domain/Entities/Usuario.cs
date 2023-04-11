using MDN.DDD.Domain.Enums;
using MDN.DDD.Domain.Exceptions;

namespace MDN.DDD.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }

        //public int EmpresaId { get; set; }
        //public virtual Empresa Empresa { get; set; }

        //public int EnderecoId { get; set; }
        //public virtual Endereco Endereco { get; set; }
        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; } = new Perfil();

        //public virtual ICollection<Departamento> Departamentos { get; set; }



        public void EstaConsistente()
        {
            NomeTemLimiteDeTamanhoDoFormato();
            NomeNaoPodeSerVazio();
        }

        private void NomeTemLimiteDeTamanhoDoFormato()
        {
            if (this.Nome.Trim().Length > 5)
            {
                throw new InformacaoException(StatusException.TamanhoDoFormato,
                    $"Campo(s) com tamanho(s) incorreto(s). Nome Tamanho limite 5");
            }
        }

        private void NomeNaoPodeSerVazio()
        {
            if (this.Nome.Trim().Length <= 0)
            {
               throw new InformacaoException(StatusException.TamanhoDoFormato,
                    $"Campo(s) com tamanho(s) incorreto(s). {Nome} Tamanho limite 5");
            }
        }

    }
}
