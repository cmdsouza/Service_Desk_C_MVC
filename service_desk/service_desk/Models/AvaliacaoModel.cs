using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class AvaliacaoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Valor' obrigatório!")]
        public int Valor { get; set; }

        public string Texto { get; set; }

        public int IdChamado { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
