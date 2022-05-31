using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class AlertaRepositorio : IAlertaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AlertaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AlertaModel Adicionar(AlertaModel alerta)
        {
            // gravar no banco de dados
            alerta.DataCriacao = System.DateTime.Now;
            _bancoContext.Alertas.Add(alerta);
            _bancoContext.SaveChanges();

            return alerta;
        }

        public bool Apagar(int id)
        {
            AlertaModel alertaDB = ListarPorId(id);
            if (alertaDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o alerta não existe no banco de dados");

            _bancoContext.Alertas.Remove(alertaDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public AlertaModel Atualizar(AlertaModel alerta)
        {
            AlertaModel alertaDB = ListarPorId(alerta.Id);
            if (alertaDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o alerta não existe no banco de dados");

            alertaDB.Titulo = alerta.Titulo;
            alertaDB.Descricao = alerta.Descricao;
            alertaDB.Status = alerta.Status;
            alertaDB.Cor = alerta.Cor;
            alertaDB.DataAtualizacao = System.DateTime.Now;
            
            _bancoContext.Alertas.Update(alertaDB);
            _bancoContext.SaveChanges();

            return alertaDB;
        }

        public List<AlertaModel> BuscarTodos()
        {
            return _bancoContext.Alertas.ToList();
        }

        public AlertaModel ListarPorId(int id)
        {
            return _bancoContext.Alertas.FirstOrDefault(x => x.Id == id);
        }
    }
}
