using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class AlertaModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Título' obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo 'Descrição' obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo 'Status' obrigatório!")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo 'Cor' obrigatório!")]
        public string Cor { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
