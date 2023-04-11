using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Enums;
using MDN.DDD.Domain.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace MDN.DDD.Domain.Contracts.Requests
{
    public class UsuarioRequest
    {

        [Required(ErrorMessage = "O campo 'Nome' é obrigatorio")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "Use apenas letras no campo 'Nome'")]
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public int PerfilId { get; set; }

        


        //public UsuarioRequest()
        //{
        //  //  EstaConsistente();

        //    if (string.IsNullOrEmpty(Cpf))
        //    {
        //        // Create a List using Range    
        //        //List<string> strings = new List<string>(new string[] { $"Usuário sem acesso. {Cpf}", "2", "3" });
        //        //throw new InformacaoException(StatusException.NaoEncontrado, strings);
        //        //throw new InformacaoException(StatusException.NaoEncontrado, $"Usuário sem acesso. {Cpf}");
        //        throw new InformacaoException(StatusException.NaoEncontrado, $"Usuário não encontrado. {Cpf}");

        //    }

        //}

       


    }
}

