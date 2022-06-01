using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class TipoContatoRepositorio : ITipoContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public TipoContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public TipoContatoModel Adicionar(TipoContatoModel tipoContato)
        {
            // gravar no banco de dados
            tipoContato.DataCriacao = System.DateTime.Now;
            _bancoContext.TipoContatos.Add(tipoContato);
            _bancoContext.SaveChanges();

            return tipoContato;
        }

        public bool Apagar(int id)
        {
            TipoContatoModel tipoContatoDB = ListarPorId(id);
            if (tipoContatoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o tipoContato não existe no banco de dados");

            _bancoContext.TipoContatos.Remove(tipoContatoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public TipoContatoModel Atualizar(TipoContatoModel tipoContato)
        {
            TipoContatoModel tipoContatoDB = ListarPorId(tipoContato.Id);
            if (tipoContatoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o tipoContato não existe no banco de dados");

            tipoContatoDB.Icone = tipoContato.Icone;
            tipoContatoDB.Descricao = tipoContato.Descricao;
            tipoContatoDB.DataAtualizacao = System.DateTime.Now;
            
            _bancoContext.TipoContatos.Update(tipoContatoDB);
            _bancoContext.SaveChanges();

            return tipoContatoDB;
        }

        public List<TipoContatoModel> BuscarTodos()
        {
            return _bancoContext.TipoContatos.ToList();
        }

        public TipoContatoModel ListarPorId(int id)
        {
            return _bancoContext.TipoContatos.FirstOrDefault(x => x.Id == id);
        }
    }
}
