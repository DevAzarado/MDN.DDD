using System.Text.Json.Serialization;

namespace MDN.DDD.Domain.Contracts.Responses
{
    public class BrasilApiResponse
    {

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Regiao { get; set; }

        public string Rua { get; set; }

        public string Servico { get; set; }
    }
}
