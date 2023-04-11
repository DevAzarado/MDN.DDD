using MDN.DDD.Domain.Enums;
using MDN.DDD.Domain.Utils;

namespace MDN.DDD.Domain.Contracts.Responses
{
    public class InformacaoResponse
    {
        public StatusException Codigo { get; set;}
        public string Descricao { get { return Codigo.Description(); } }
        public List<string> Mensagens { get; set; }
        public string Detalhe { get; set; }
    }
}
