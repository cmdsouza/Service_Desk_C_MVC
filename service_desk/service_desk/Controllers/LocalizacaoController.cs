using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class LocalizacaoController : Controller
    {
        private readonly ILocalizacaoRepositorio _localizacaoRepositorio;

        public LocalizacaoController(ILocalizacaoRepositorio localizacaoRepositorio)
        {
            _localizacaoRepositorio = localizacaoRepositorio;
        }

        public IActionResult Index()
        {
            List<LocalizacaoModel> localizacaos = _localizacaoRepositorio.BuscarTodos();
            return View(localizacaos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            LocalizacaoModel localizacao = _localizacaoRepositorio.ListarPorId(id);
            return View(localizacao);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            LocalizacaoModel localizacao = _localizacaoRepositorio.ListarPorId(id);
            return View(localizacao);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _localizacaoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Localizacao excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir a localizacao.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir a localizacao. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(LocalizacaoModel localizacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _localizacaoRepositorio.Adicionar(localizacao);
                    TempData["MensagemSucesso"] = "Localizacao cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(localizacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o localizacao. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(LocalizacaoModel localizacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _localizacaoRepositorio.Atualizar(localizacao);
                    TempData["MensagemSucesso"] = "Localizacao atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", localizacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o localizacao. Detalhes do erro {erro.Message}";
                return View("Editar", localizacao);
            }
        }
    }
}
