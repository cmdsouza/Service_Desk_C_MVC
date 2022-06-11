using Microsoft.AspNetCore.Mvc;
using service_desk.Helper;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class AlertaController : GenericoController
    {
        private readonly IAlertaRepositorio _alertaRepositorio;

        public AlertaController(IAlertaRepositorio alertaRepositorio, ISessao sessao) : base(sessao)
        {
            _alertaRepositorio = alertaRepositorio;
        }

        public IActionResult Index()
        {
            List<AlertaModel> alertas = _alertaRepositorio.BuscarTodos();
            return View(alertas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            AlertaModel alerta = _alertaRepositorio.ListarPorId(id);
            return View(alerta);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            AlertaModel alerta = _alertaRepositorio.ListarPorId(id);
            return View(alerta);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _alertaRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Alerta excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o alerta.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o alerta. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(AlertaModel alerta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    _alertaRepositorio.Adicionar(alerta);
                    TempData["MensagemSucesso"] = "Alerta cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(alerta);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o alerta. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(AlertaModel alerta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _alertaRepositorio.Atualizar(alerta);
                    TempData["MensagemSucesso"] = "Alerta atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", alerta);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o alerta. Detalhes do erro {erro.Message}";
                return View("Editar", alerta);
            }
        }

    }
}
