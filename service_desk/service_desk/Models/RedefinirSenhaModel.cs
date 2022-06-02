using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class RedefinirSenhaModel
	{
		[Required(ErrorMessage = "Campo 'Login' obrigatório!")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Campo 'Email' obrigatório!")]
		public string Email { get; set; }
	}
}
