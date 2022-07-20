using System.Collections.Generic;

namespace service_desk.Models
{
    public class DadosSolucaoModel
    {
        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public class DadosSolucao
        {
            public int id { get; set; }
            public string itemtype { get; set; }
            public int items_id { get; set; }
            public int solutiontypes_id { get; set; }
            public object solutiontype_name { get; set; }
            public string content { get; set; }
            public string date_creation { get; set; }
            public string date_mod { get; set; }
            public string date_approval { get; set; }
            public int users_id { get; set; }
            public object user_name { get; set; }
            public int users_id_editor { get; set; }
            public int users_id_approval { get; set; }
            public object user_name_approval { get; set; }
            public int status { get; set; }
            public object itilfollowups_id { get; set; }
            public List<Link> links { get; set; }
        }
    }
}
