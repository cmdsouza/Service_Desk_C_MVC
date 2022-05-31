using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class AnexoRepositorio : IAnexoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AnexoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AnexoModel Adicionar(AnexoModel anexo)
        {
            // gravar no banco de dados
            anexo.DataCriacao = System.DateTime.Now;
            _bancoContext.Anexos.Add(anexo);
            _bancoContext.SaveChanges();

            return anexo;
        }

        public bool Apagar(int id)
        {
            AnexoModel anexoDB = ListarPorId(id);
            if (anexoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o anexo não existe no banco de dados");

            _bancoContext.Anexos.Remove(anexoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public AnexoModel Atualizar(AnexoModel anexo)
        {
            AnexoModel anexoDB = ListarPorId(anexo.Id);
            if (anexoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o anexo não existe no banco de dados");

            anexoDB.Arquivo = anexo.Arquivo;
            anexoDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Anexos.Update(anexoDB);
            _bancoContext.SaveChanges();

            return anexoDB;
        }

        public List<AnexoModel> BuscarTodos()
        {
            return _bancoContext.Anexos.ToList();
        }

        public AnexoModel ListarPorId(int id)
        {
            return _bancoContext.Anexos.FirstOrDefault(x => x.Id == id);
        }
    }
}
