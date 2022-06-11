using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class LocalizacaoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Lugar' obrigatório!")]
        public string Lugar { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual UsuarioModel Usuario { get; set; }
    }
}
