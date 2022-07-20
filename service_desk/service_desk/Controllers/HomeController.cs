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
            var token = _glpi.RecuperarSessionToken().Result;
            TempData["token"] = token.session_token;

            var matricula = _sessao.BuscarSessaoDoUsuario().Matricula;

            var dadosUsuario = _glpi.ObterDadosUsuarioPelaMatricula(matricula).Result;
            var idUsuario = dadosUsuario.data.Select(a => a.id).FirstOrDefault();
            
            var dadosChamados = _glpi.ObterChamadosPorUsuario(idUsuario).Result;
            TempData["quantChamados"] = dadosChamados.totalcount;
            TempData["listaChamados"] = dadosChamados.data.ToList(); // pegar a lista de chamados

            var chamadosAbertos = _glpi.QuantidadeChamadosSolucionados(272).Result;
            TempData["quantChamadosSolucionados"] = chamadosAbertos.totalcount;

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

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
