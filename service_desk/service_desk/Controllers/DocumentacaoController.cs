using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class DocumentacaoController : Controller
    {
        private readonly IDocumentacaoRepositorio _documentacaoRepositorio;

        public DocumentacaoController(IDocumentacaoRepositorio documentacaoRepositorio)
        {
            _documentacaoRepositorio = documentacaoRepositorio;
        }

        public IActionResult Index()
        {
            List<DocumentacaoModel> documentacaos = _documentacaoRepositorio.BuscarTodos();
            return View(documentacaos);
        }

        public IActionResult ListaUsuario()
        {
            List<DocumentacaoModel> documentacaos = _documentacaoRepositorio.BuscarTodos();
            return View(documentacaos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            DocumentacaoModel documentacao = _documentacaoRepositorio.ListarPorId(id);
            return View(documentacao);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            DocumentacaoModel documentacao = _documentacaoRepositorio.ListarPorId(id);
            return View(documentacao);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _documentacaoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Documentação excluída com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir a documentação.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir a documentação. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(DocumentacaoModel documentacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentacaoRepositorio.Adicionar(documentacao);
                    TempData["MensagemSucesso"] = "Documentação cadastrada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(documentacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar a documentação. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(DocumentacaoModel documentacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentacaoRepositorio.Atualizar(documentacao);
                    TempData["MensagemSucesso"] = "Documentação atualizada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", documentacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar a documentação. Detalhes do erro: {erro.Message}";
                return View("Editar", documentacao);
            }
        }
    }
}
