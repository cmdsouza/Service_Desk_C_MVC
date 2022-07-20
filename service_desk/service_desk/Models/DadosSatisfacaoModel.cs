using System.Collections.Generic;

namespace service_desk.Models
{
    public class DadosSatisfacaoModel
    {
        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public class DadosSatisfacao
        {
            public int id { get; set; }
            public int tickets_id { get; set; }
            public int type { get; set; }
            public string date_begin { get; set; }
            public string date_answered { get; set; }
            public int satisfaction { get; set; }
            public object comment { get; set; }
            public List<Link> links { get; set; }
        }

    }
}
