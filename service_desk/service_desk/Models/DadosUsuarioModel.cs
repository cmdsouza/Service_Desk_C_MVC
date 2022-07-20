using Newtonsoft.Json;
using System.Collections.Generic;

namespace service_desk.Models
{
    public class DadosUsuarioModel
    {
        public class Matriculas
        {
            [JsonProperty("1")]
            public string matricula { get; set; }
            [JsonProperty("2")]
            public int id { get; set; }
        }

        public class DadosUsuario
        {
            public int totalcount { get; set; }
            public int count { get; set; }
            public string sort { get; set; }
            public string order { get; set; }
            public List<Matriculas> data { get; set; }

            [JsonProperty("content-range")]
            public string ContentRange { get; set; }
        }
    }
}
