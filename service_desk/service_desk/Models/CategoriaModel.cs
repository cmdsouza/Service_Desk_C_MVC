using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class CategoriaModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório!")]
        public string Nome { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual UsuarioModel Usuario { get; set; }
    }
}
