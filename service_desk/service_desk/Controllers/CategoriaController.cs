using Microsoft.AspNetCore.Mvc;
using service_desk.Helper;
using service_desk.Models;
using service_desk.Repositorio;
using System.Collections.Generic;

namespace service_desk.Controllers
{
    public class CategoriaController : GenericoController
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaController(ICategoriaRepositorio categoriaRepositorio, ISessao sessao) : base(sessao)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public IActionResult Index()
        {
            List<CategoriaModel> categorias = _categoriaRepositorio.BuscarTodos();
            return View(categorias);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            CategoriaModel categoria = _categoriaRepositorio.ListarPorId(id);
            return View(categoria);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            CategoriaModel categoria = _categoriaRepositorio.ListarPorId(id);
            return View(categoria);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _categoriaRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Categoria excluída com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao excluir a categoria.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir a categoria. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(CategoriaModel categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoriaRepositorio.Adicionar(categoria);
                    TempData["MensagemSucesso"] = "Categoria cadastrada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(categoria);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar a categoria. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(CategoriaModel categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoriaRepositorio.Atualizar(categoria);
                    TempData["MensagemSucesso"] = "Categoria atualizada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", categoria);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao editar a categoria. Detalhes do erro: {erro.Message}";
                return View("Editar", categoria);
            }
        }
    }
}
