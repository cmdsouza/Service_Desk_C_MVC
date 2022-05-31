using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class AnexoController : Controller
    {
        private readonly IAnexoRepositorio _anexoRepositorio;

        public AnexoController(IAnexoRepositorio anexoRepositorio)
        {
            _anexoRepositorio = anexoRepositorio;
        }

        public IActionResult Index()
        {
            List<AnexoModel> anexos = _anexoRepositorio.BuscarTodos();
            return View(anexos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            AnexoModel anexo = _anexoRepositorio.ListarPorId(id);
            return View(anexo);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            AnexoModel anexo = _anexoRepositorio.ListarPorId(id);
            return View(anexo);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _anexoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Anexo excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o anexo.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o anexo. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(AnexoModel anexo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _anexoRepositorio.Adicionar(anexo);
                    TempData["MensagemSucesso"] = "Anexo cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(anexo);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o anexo. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(AnexoModel anexo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _anexoRepositorio.Atualizar(anexo);
                    TempData["MensagemSucesso"] = "Anexo atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", anexo);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o anexo. Detalhes do erro {erro.Message}";
                return View("Editar", anexo);
            }
        }
    }
}
