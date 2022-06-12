using Microsoft.AspNetCore.Mvc;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class TipoContatoController : Controller
    {
        private readonly ITipoContatoRepositorio _tipoContatoRepositorio;

        public TipoContatoController(ITipoContatoRepositorio tipoContatoRepositorio)
        {
            _tipoContatoRepositorio = tipoContatoRepositorio;
        }

        public IActionResult Index()
        {
            List<TipoContatoModel> tipoContatos = _tipoContatoRepositorio.BuscarTodos();
            return View(tipoContatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            TipoContatoModel tipoContato = _tipoContatoRepositorio.ListarPorId(id);
            return View(tipoContato);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            TipoContatoModel tipoContato = _tipoContatoRepositorio.ListarPorId(id);
            return View(tipoContato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _tipoContatoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Tipo de contato excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir o tipo de contato.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir o tipo de contato. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(TipoContatoModel tipoContatoControl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _tipoContatoRepositorio.Adicionar(tipoContatoControl);
                    TempData["MensagemSucesso"] = "Tipo de contato cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(tipoContatoControl);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o tipo de contato. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(TipoContatoModel tipoContatoControl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _tipoContatoRepositorio.Atualizar(tipoContatoControl);
                    TempData["MensagemSucesso"] = "Tipo de contato atualizado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", tipoContatoControl);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar o tipo de contato. Detalhes do erro: {erro.Message}";
                return View("Editar", tipoContatoControl);
            }
        }
    }
}
