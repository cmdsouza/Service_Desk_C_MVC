using service_desk.Models;

namespace service_desk.Helper
{
	public interface ISessao
	{
		void CriarSessaoDoUsuario(UsuarioModel usuario);
		void RemoverSessaoDoUsurio();
		UsuarioModel BuscarSessaoDoUsuario();
	}
}
