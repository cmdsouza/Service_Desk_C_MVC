using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class AvaliacaoRepositorio : IAvaliacaoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AvaliacaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AvaliacaoModel Adicionar(AvaliacaoModel avaliacao)
        {
            // gravar no banco de dados
            avaliacao.DataCriacao = System.DateTime.Now;
            _bancoContext.Avaliacaos.Add(avaliacao);
            _bancoContext.SaveChanges();

            return avaliacao;
        }

        public bool Apagar(int id)
        {
            AvaliacaoModel avaliacaoDB = ListarPorId(id);
            if (avaliacaoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o avaliacao não existe no banco de dados");

            _bancoContext.Avaliacaos.Remove(avaliacaoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public AvaliacaoModel Atualizar(AvaliacaoModel avaliacao)
        {
            AvaliacaoModel avaliacaoDB = ListarPorId(avaliacao.Id);
            if (avaliacaoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o avaliacao não existe no banco de dados");

            avaliacaoDB.Valor = avaliacao.Valor;
            avaliacaoDB.Texto = avaliacao.Texto;
            avaliacaoDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Avaliacaos.Update(avaliacaoDB);
            _bancoContext.SaveChanges();

            return avaliacaoDB;
        }

        public List<AvaliacaoModel> BuscarTodos()
        {
            return _bancoContext.Avaliacaos.ToList();
        }

        public AvaliacaoModel ListarPorId(int id)
        {
            return _bancoContext.Avaliacaos.FirstOrDefault(x => x.Id == id);
        }
    }
}
