using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;

        public ChamadoController(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio = chamadoRepositorio;
        }

        public IActionResult Index()
        {
            List<ChamadoModel> chamados = _chamadoRepositorio.BuscarTodos();
            return View(chamados);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ChamadoModel chamado = _chamadoRepositorio.ListarPorId(id);
            return View(chamado);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ChamadoModel chamado = _chamadoRepositorio.ListarPorId(id);
            return View(chamado);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _chamadoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Chamado excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o chamado.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o chamado. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(ChamadoModel chamado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _chamadoRepositorio.Adicionar(chamado);
                    TempData["MensagemSucesso"] = "Chamado cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(chamado);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o chamado. Detalhes do erro {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(ChamadoModel chamado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _chamadoRepositorio.Atualizar(chamado);
                    TempData["MensagemSucesso"] = "Chamado atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", chamado);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o chamado. Detalhes do erro {erro.Message}";
                return View("Editar", chamado);
            }
        }
    }
}
