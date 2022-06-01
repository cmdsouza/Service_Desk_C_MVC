using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class LocalizacaoRepositorio : ILocalizacaoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public LocalizacaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public LocalizacaoModel Adicionar(LocalizacaoModel localizacao)
        {
            // gravar no banco de dados
            localizacao.DataCriacao = System.DateTime.Now;
            _bancoContext.Localizacaos.Add(localizacao);
            _bancoContext.SaveChanges();

            return localizacao;
        }

        public bool Apagar(int id)
        {
            LocalizacaoModel localizacaoDB = ListarPorId(id);
            if (localizacaoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o localizacao não existe no banco de dados");

            _bancoContext.Localizacaos.Remove(localizacaoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public LocalizacaoModel Atualizar(LocalizacaoModel localizacao)
        {
            LocalizacaoModel localizacaoDB = ListarPorId(localizacao.Id);
            if (localizacaoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o localizacao não existe no banco de dados");

            localizacaoDB.Lugar = localizacao.Lugar;
            localizacaoDB.DataAtualizacao = System.DateTime.Now;
            
            _bancoContext.Localizacaos.Update(localizacaoDB);
            _bancoContext.SaveChanges();

            return localizacaoDB;
        }

        public List<LocalizacaoModel> BuscarTodos()
        {
            return _bancoContext.Localizacaos.ToList();
        }

        public LocalizacaoModel ListarPorId(int id)
        {
            return _bancoContext.Localizacaos.FirstOrDefault(x => x.Id == id);
        }
    }
}
