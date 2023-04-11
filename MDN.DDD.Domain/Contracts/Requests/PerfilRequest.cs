using System.ComponentModel.DataAnnotations;

namespace MDN.DDD.Domain.Contracts.Requests
{
    public class PerfilRequest
    {

        [Required(ErrorMessage = "O campo 'Nome' é obrigatorio")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "Use apenas letras no campo 'Nome'")]
        public string Nome { get; set; }
    }
}
