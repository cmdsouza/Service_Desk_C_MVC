using System.ComponentModel.DataAnnotations;

namespace service_desk.Models
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Campo 'Login' obrigatório!")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Campo 'Senha' obrigatório!")]
		public string Senha { get; set; }
	}
}
