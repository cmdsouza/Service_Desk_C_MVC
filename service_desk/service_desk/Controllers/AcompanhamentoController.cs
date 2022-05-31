using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class AcompanhamentoController : Controller
    {
        private readonly IAcompanhamentoRepositorio _acompanhamentoRepositorio;

        public AcompanhamentoController(IAcompanhamentoRepositorio acompanhamentoRepositorio)
        {
            _acompanhamentoRepositorio = acompanhamentoRepositorio;
        }

        public IActionResult Index()
        {
            List<AcompanhamentoModel> acompanhamentos = _acompanhamentoRepositorio.BuscarTodos();
            return View(acompanhamentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            AcompanhamentoModel acompanhamento = _acompanhamentoRepositorio.ListarPorId(id);
            return View(acompanhamento);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            AcompanhamentoModel acompanhamento = _acompanhamentoRepositorio.ListarPorId(id);
            return View(acompanhamento);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _acompanhamentoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Acompanhamento excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o acompanhamento.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o acompanhamento. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(AcompanhamentoModel acompanhamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _acompanhamentoRepositorio.Adicionar(acompanhamento);
                    TempData["MensagemSucesso"] = "Acompanhamento cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(acompanhamento);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o acompanhamento. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(AcompanhamentoModel acompanhamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _acompanhamentoRepositorio.Atualizar(acompanhamento);
                    TempData["MensagemSucesso"] = "Acompanhamento atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", acompanhamento);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o acompanhamento. Detalhes do erro {erro.Message}";
                return View("Editar", acompanhamento);
            }
        }
    }
}
