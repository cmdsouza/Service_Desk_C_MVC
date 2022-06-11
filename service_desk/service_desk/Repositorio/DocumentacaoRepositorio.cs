using service_desk.Data;
using service_desk.Helper;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class DocumentacaoRepositorio : Repositorio, IDocumentacaoRepositorio
    {
        public DocumentacaoRepositorio(BancoContext bancoContext, ISessao sessao) : base(bancoContext, sessao)
        {
        }

        public DocumentacaoModel Adicionar(DocumentacaoModel documentacao)
        {
            // gravar no banco de dados
            documentacao.DataCriacao = System.DateTime.Now;
            _bancoContext.Documentacaos.Add(documentacao);
            _bancoContext.SaveChanges();

            return documentacao;
        }

        public bool Apagar(int id)
        {
            DocumentacaoModel documentacaoDB = ListarPorId(id);
            if (documentacaoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o documentacao não existe no banco de dados");

            _bancoContext.Documentacaos.Remove(documentacaoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public DocumentacaoModel Atualizar(DocumentacaoModel documentacao)
        {
            DocumentacaoModel documentacaoDB = ListarPorId(documentacao.Id);
            if (documentacaoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o documentacao não existe no banco de dados");

            documentacaoDB.TituloLink = documentacao.TituloLink;
            documentacaoDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Documentacaos.Update(documentacaoDB);
            _bancoContext.SaveChanges();

            return documentacaoDB;
        }

        public List<DocumentacaoModel> BuscarTodos()
        {
            return _bancoContext.Documentacaos.ToList();
        }

        public DocumentacaoModel ListarPorId(int id)
        {
            return _bancoContext.Documentacaos.FirstOrDefault(x => x.Id == id);
        }
    }
}
