﻿using service_desk.Data;
using service_desk.Helper;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class AlertaRepositorio : Repositorio, IAlertaRepositorio
    {
        public AlertaRepositorio(BancoContext bancoContext, ISessao sessao) : base(bancoContext, sessao)
        {
        }

        public AlertaModel Adicionar(AlertaModel alerta)
        {
            // gravar no banco de dados
            alerta.DataCriacao = System.DateTime.Now;
            alerta.IdUsuario = _usuario.Id;
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

        public AlertaModel AtivarStatus(AlertaModel alerta)
        {
            AlertaModel alertaDB = ListarPorId(alerta.Id);
            if (alertaDB == null) throw new System.Exception("Erro: não foi possível ativar, pois o alerta não existe no banco de dados");

            alertaDB.Status = alerta.Status;
            alertaDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Alertas.Update(alertaDB);
            _bancoContext.SaveChanges();

            return alertaDB;
        }

        public AlertaModel DesativarStatus(AlertaModel alerta)
        {
            AlertaModel alertaDB = ListarPorId(alerta.Id);
            if (alertaDB == null) throw new System.Exception("Erro: não foi possível desativar, pois o alerta não existe no banco de dados");

            alertaDB.Status = alerta.Status;
            alertaDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Alertas.Update(alertaDB);
            _bancoContext.SaveChanges();

            return alertaDB;
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

        public List<AlertaModel> ListarAtivo()
        {
            IEnumerable<AlertaModel> alertasAtivos =
                from alerta in BuscarTodos()
                where alerta.Status == "Ativo"
                orderby alerta.DataAtualizacao descending
                select alerta;

            List<AlertaModel> alertaAtivo = alertasAtivos.Take(1).ToList();

            return alertaAtivo;
        }

    }
}
