using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class AcompanhamentoRepositorio : IAcompanhamentoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AcompanhamentoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AcompanhamentoModel Adicionar(AcompanhamentoModel acompanhamento)
        {
            // gravar no banco de dados
            acompanhamento.DataCriacao = System.DateTime.Now;
            _bancoContext.Acompanhamentos.Add(acompanhamento);
            _bancoContext.SaveChanges();

            return acompanhamento;
        }

        public bool Apagar(int id)
        {
            AcompanhamentoModel acompanhamentoDB = ListarPorId(id);
            if (acompanhamentoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o acompanhamento não existe no banco de dados");

            _bancoContext.Acompanhamentos.Remove(acompanhamentoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public AcompanhamentoModel Atualizar(AcompanhamentoModel acompanhamento)
        {
            AcompanhamentoModel acompanhamentoDB = ListarPorId(acompanhamento.Id);
            if (acompanhamentoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o acompanhamento não existe no banco de dados");

            acompanhamentoDB.Descricao = acompanhamento.Descricao;
            acompanhamentoDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Acompanhamentos.Update(acompanhamentoDB);
            _bancoContext.SaveChanges();

            return acompanhamentoDB;
        }

        public List<AcompanhamentoModel> BuscarTodos()
        {
            return _bancoContext.Acompanhamentos.ToList();
        }

        public AcompanhamentoModel ListarPorId(int id)
        {
            return _bancoContext.Acompanhamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}
