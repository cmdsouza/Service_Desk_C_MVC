using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class ContatoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Contato' obrigatório!")]
        public string Descricao { get; set; }

        public string IdTipoContato { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
