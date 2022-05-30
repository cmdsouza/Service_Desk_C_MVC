using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class ChamadoModel
	{
        public int Id { get; set; }

        public string Observadores { get; set; }

        [Required(ErrorMessage = "Campo 'Título' obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo 'Status' obrigatório!")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo 'Origem' obrigatório!")]
        public string Origem { get; set; }

        [Required(ErrorMessage = "Campo 'Localizacao' obrigatório!")]
        public string Localizacao { get; set; }

        public int IdUsuario { get; set; }

        public int IdCategoria { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}
