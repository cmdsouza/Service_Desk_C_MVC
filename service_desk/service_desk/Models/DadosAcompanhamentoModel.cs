using System.Collections.Generic;

namespace service_desk.Models
{
    public class DadosAcompanhamentoModel
    {
        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public class Informacoes
        {
            public int id { get; set; }
            public string date { get; set; }
            public int users_id { get; set; }
            public int users_id_editor { get; set; }
            public string content { get; set; }
            public int is_private { get; set; }
            public int requesttypes_id { get; set; }
            public string date_mod { get; set; }
            public string date_creation { get; set; }
            public int timeline_position { get; set; }
            public List<Link> links { get; set; }
            public int tickets_id { get; set; }
        }
    }
}
