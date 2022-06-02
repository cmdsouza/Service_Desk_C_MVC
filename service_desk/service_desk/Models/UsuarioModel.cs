using service_desk.Helper;
using System;
using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class UsuarioModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Matrícula' obrigatório!")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo 'Senha' obrigatório!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo 'Autorização' obrigatório!")]
        public string Autorizacao { get; set; }

        [Required(ErrorMessage = "Campo 'Email' obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo 'Telefone' obrigatório!")]
        public string Telefone { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
		{
            return Senha == senha.GerarHash();
		}

        public void SetSenhaHash()
		{
            Senha = Senha.GerarHash();
		}

        public string GerarNovaSenha()
		{
            string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
		}
    }
}
