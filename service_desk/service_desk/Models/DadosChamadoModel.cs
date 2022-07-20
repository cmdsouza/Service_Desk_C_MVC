using Newtonsoft.Json;
using System.Collections.Generic;

namespace service_desk.Models
{
    public class DadosChamadoModel
    {
        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public class DadosChamado
        {
            public int id { get; set; }
            public int entities_id { get; set; }
            public string name { get; set; }
            public string date { get; set; }
            public string closedate { get; set; }
            public string solvedate { get; set; }
            public string date_mod { get; set; }
            public int users_id_lastupdater { get; set; }
            public int status { get; set; }
            public int users_id_recipient { get; set; }
            public int requesttypes_id { get; set; }
            public string content { get; set; }
            public int urgency { get; set; }
            public int impact { get; set; }
            public int priority { get; set; }
            public int itilcategories_id { get; set; }
            public int type { get; set; }
            public int global_validation { get; set; }
            public int slas_id_ttr { get; set; }
            public int slas_id_tto { get; set; }
            public int slalevels_id_ttr { get; set; }
            public object time_to_resolve { get; set; }
            public object time_to_own { get; set; }
            public string begin_waiting_date { get; set; }
            public int sla_waiting_duration { get; set; }
            public int ola_waiting_duration { get; set; }
            public int olas_id_tto { get; set; }
            public int olas_id_ttr { get; set; }
            public int olalevels_id_ttr { get; set; }
            public object ola_ttr_begin_date { get; set; }
            public object internal_time_to_resolve { get; set; }
            public object internal_time_to_own { get; set; }
            public int waiting_duration { get; set; }
            public int close_delay_stat { get; set; }
            public int solve_delay_stat { get; set; }
            public int takeintoaccount_delay_stat { get; set; }
            public int actiontime { get; set; }
            public int is_deleted { get; set; }
            public int locations_id { get; set; }
            public int validation_percent { get; set; }
            public string date_creation { get; set; }
            public List<Link> links { get; set; }
        }
    }
}
