using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public CategoriaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public CategoriaModel Adicionar(CategoriaModel categoria)
        {
            // gravar no banco de dados
            categoria.DataCriacao = System.DateTime.Now;
            _bancoContext.Categorias.Add(categoria);
            _bancoContext.SaveChanges();

            return categoria;
        }

        public bool Apagar(int id)
        {
            CategoriaModel categoriaDB = ListarPorId(id);
            if (categoriaDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o categoria não existe no banco de dados");

            _bancoContext.Categorias.Remove(categoriaDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public CategoriaModel Atualizar(CategoriaModel categoria)
        {
            CategoriaModel categoriaDB = ListarPorId(categoria.Id);
            if (categoriaDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o categoria não existe no banco de dados");

            categoriaDB.Nome = categoria.Nome;
            categoriaDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Categorias.Update(categoriaDB);
            _bancoContext.SaveChanges();

            return categoriaDB;
        }

        public List<CategoriaModel> BuscarTodos()
        {
            return _bancoContext.Categorias.ToList();
        }

        public CategoriaModel ListarPorId(int id)
        {
            return _bancoContext.Categorias.FirstOrDefault(x => x.Id == id);
        }
    }
}
