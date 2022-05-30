using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class AcompanhamentoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Descrição' obrigatório!")]
        public string Descricao { get; set; }

        public string Tipo { get; set; }

        public int IdChamado { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
