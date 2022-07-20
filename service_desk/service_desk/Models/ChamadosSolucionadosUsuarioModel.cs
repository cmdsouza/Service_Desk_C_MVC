using Newtonsoft.Json;
using System.Collections.Generic;

namespace service_desk.Models
{
    public class ChamadosSolucionadosUsuarioModel
    {
        public class Informacoes
        {
            [JsonProperty("2")]
            public int id { get; set; }
            
            [JsonProperty("1")]
            public string titulo { get; set; }
            
            [JsonProperty("12")]
            public int status { get; set; }
           
            [JsonProperty("15")]
            public string dataAbertura { get; set; }
            
            [JsonProperty("4")]
            public string idUsuario { get; set; }
            
            [JsonProperty("83")]
            public string localizacao { get; set; }
           
            [JsonProperty("7")]
            public string _7 { get; set; }
            
            [JsonProperty("5")]
            public string _5 { get; set; }
           
            [JsonProperty("8")]
            public string grupoTecnico { get; set; }
            
            [JsonProperty("19")]
            public string dataAtualizacao { get; set; }
        }

        public class ChamadosSolucionadosUsuario
        {
            public int totalcount { get; set; }
            public int count { get; set; }
            public string sort { get; set; }
            public string order { get; set; }
            public List<Informacoes> data { get; set; }

            [JsonProperty("content-range")]
            public string ContentRange { get; set; }
        }
    }
}
