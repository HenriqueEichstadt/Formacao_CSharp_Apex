using System.Text.Json.Serialization;

namespace MeuProjetoApi.Models
{
    public class ViaCep
    {
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string EnderecoLogradouro { get; set; } // "logradouro": "",
        
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
    }
}


/*
 {
  "cep": "95717-000",
  "logradouro": "",
  "complemento": "",
  "bairro": "",
  "localidade": "Pinto Bandeira",
  "uf": "RS",
  "ibge": "4314548",
  "gia": "",
  "ddd": "54",
  "siafi": "1160"
}
 
 */
