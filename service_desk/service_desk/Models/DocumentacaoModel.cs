using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class DocumentacaoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Titulos e Links' obrigatório!")]
        public string TituloLink { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
