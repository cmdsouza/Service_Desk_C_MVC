using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class AvaliacaoController : Controller
    {
        private readonly IAvaliacaoRepositorio _avaliacaoRepositorio;

        public AvaliacaoController(IAvaliacaoRepositorio avaliacaoRepositorio)
        {
            _avaliacaoRepositorio = avaliacaoRepositorio;
        }

        public IActionResult Index()
        {
            List<AvaliacaoModel> avaliacaos = _avaliacaoRepositorio.BuscarTodos();
            return View(avaliacaos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            AvaliacaoModel avaliacao = _avaliacaoRepositorio.ListarPorId(id);
            return View(avaliacao);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            AvaliacaoModel avaliacao = _avaliacaoRepositorio.ListarPorId(id);
            return View(avaliacao);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _avaliacaoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Avaliacao excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o avaliacao.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o avaliacao. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(AvaliacaoModel avaliacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _avaliacaoRepositorio.Adicionar(avaliacao);
                    TempData["MensagemSucesso"] = "Avaliacao cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(avaliacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o avaliacao. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(AvaliacaoModel avaliacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _avaliacaoRepositorio.Atualizar(avaliacao);
                    TempData["MensagemSucesso"] = "Avaliacao atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", avaliacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o avaliacao. Detalhes do erro {erro.Message}";
                return View("Editar", avaliacao);
            }
        }
    }
}
