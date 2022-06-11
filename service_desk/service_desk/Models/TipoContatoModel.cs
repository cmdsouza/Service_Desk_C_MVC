using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class TipoContatoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Icone' obrigatório!")]
        public string Icone { get; set; }

        [Required(ErrorMessage = "Campo 'Descricao' obrigatório!")]
        public string Descricao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual ICollection<ContatoModel> Contatos { get; set; }
    }
}
