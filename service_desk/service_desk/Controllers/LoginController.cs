using Microsoft.AspNetCore.Mvc;
using service_desk.Helper;
using service_desk.Models;
using service_desk.Repositorio;
using System;

namespace service_desk.Controllers
{
    public class LoginController : Controller
    {
		private readonly IUsuarioRepositorio _usuarioRepositorio;
		private readonly ISessao _sessao;

		public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
		{
			_usuarioRepositorio = usuarioRepositorio;
			_sessao = sessao;
		}

		public IActionResult Index()
        {
			if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");
			
			return View();
        }

		public IActionResult RedefinirSenha()
		{
			return View();
		}

		public IActionResult Sair()
		{
			_sessao.RemoverSessaoDoUsurio();
			return RedirectToAction("Index", "Login");
		}

		[HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);
					if(usuario != null)
					{
						if (usuario.SenhaValida(loginModel.Senha))
						{
							_sessao.CriarSessaoDoUsuario(usuario);

                            if (usuario.Autorizacao == "Administrador")
                            {
								return RedirectToAction("Index", "Administrador");
							}
                            else
                            {
								return RedirectToAction("Index", "Home");
							}
						}
						
						TempData["MensagemErro"] = $"Senha incorreta.";
					}

					TempData["MensagemErro"] = $"Usuário e/ou senha incorretos.";
				}

				return View("Index");
			}
            catch (Exception erro)
			{
				TempData["MensagemErro"] = $"Erro ao fazer login. Detalhes do erro {erro.Message}";
				return RedirectToAction("Index");
			}
		}
	}
}
