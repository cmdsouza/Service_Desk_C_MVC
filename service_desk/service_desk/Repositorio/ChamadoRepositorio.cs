using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class ChamadoRepositorio : IChamadoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ChamadoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ChamadoModel Adicionar(ChamadoModel chamado)
        {
            // gravar no banco de dados
            chamado.DataCriacao = System.DateTime.Now;
            _bancoContext.Chamados.Add(chamado);
            _bancoContext.SaveChanges();

            return chamado;
        }

        public bool Apagar(int id)
        {
            ChamadoModel chamadoDB = ListarPorId(id);
            if (chamadoDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o chamado não existe no banco de dados");

            _bancoContext.Chamados.Remove(chamadoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public ChamadoModel Atualizar(ChamadoModel chamado)
        {
            ChamadoModel chamadoDB = ListarPorId(chamado.Id);
            if (chamadoDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o chamado não existe no banco de dados");

            chamadoDB.Titulo = chamado.Titulo;
            chamadoDB.Status = chamado.Status;
            chamadoDB.Origem = chamado.Origem;
            chamadoDB.Localizacao = chamado.Localizacao;
            chamadoDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Chamados.Update(chamadoDB);
            _bancoContext.SaveChanges();

            return chamadoDB;
        }

        public List<ChamadoModel> BuscarTodos()
        {
            return _bancoContext.Chamados.ToList();
        }

        public ChamadoModel ListarPorId(int id)
        {
            return _bancoContext.Chamados.FirstOrDefault(x => x.Id == id);
        }
    }
}
