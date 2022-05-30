using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class AnexoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Arquivo' obrigatório!")]
        public string Arquivo { get; set; }

        public int IdAcompanhamento { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
