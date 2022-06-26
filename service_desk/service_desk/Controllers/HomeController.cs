using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using service_desk.Helper;
using service_desk.Models;
using service_desk.Repositorio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace service_desk.Controllers
{
    public class HomeController : GenericoController
    {
        private readonly GLPI _glpi;
        private readonly IAlertaRepositorio _alertaRepositorio;
        private readonly IContatoRepositorio _contatoRepositorio;
        private readonly ISessao _sessao;

        public HomeController(GLPI glpiRepositorio, IAlertaRepositorio alertaRepositorio, IContatoRepositorio contatoRepositorio, ISessao sessao) : base(sessao)
        {
            _glpi = glpiRepositorio;
            _sessao = sessao;
            _alertaRepositorio = alertaRepositorio;
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            //var token = _glpi.RecuperarSessionToken();

            var resultadoAlerta = _alertaRepositorio.ListarAtivo();
            if (resultadoAlerta != null)
            {
                foreach (AlertaModel elemento in resultadoAlerta)
                {
                    TempData["AlertaTitulo"] = elemento.Titulo;
                    TempData["AlertaDescricao"] = elemento.Descricao;
                    TempData["AlertaCor"] = elemento.Cor;
                }
            }

            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            if (contatos != null)
            {
                foreach (ContatoModel contato in contatos)
                {
                    TempData["ListaContatos"] = "Aqui";
                    TempData["ListaContatos"] = contato.Descricao;
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
