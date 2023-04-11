using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MDN.DDD.Domain.Entities
{
    public class BrasilApi
    {
        [JsonProperty(PropertyName = "cep")]
        public string Cep { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string Estado { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string Cidade { get; set; }

        [JsonProperty(PropertyName = "neighborhood")]
        public string Regiao { get; set; }

        [JsonProperty(PropertyName = "street")]
        public string Rua { get; set; }

        [JsonProperty(PropertyName = "service")]
        public string Servico { get; set; }

    }
}