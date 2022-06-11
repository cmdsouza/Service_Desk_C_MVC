using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class ContatoModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Contato' obrigatório!")]
        public string Descricao { get; set; }

        public int IdTipoContato { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual UsuarioModel Usuario { get; set; }

        public virtual TipoContatoModel TipoContato { get; set; }
    }
}
