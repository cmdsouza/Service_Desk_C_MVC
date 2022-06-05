using service_desk.Data;
using service_desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace service_desk.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            // gravar no banco de dados
            usuario.DataCriacao = System.DateTime.Now;
            usuario.SetSenhaHash();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);
            if (usuarioDB == null) throw new System.Exception("Erro: não foi possível excluir, pois o usuario não existe no banco de dados");

            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);
            if (usuarioDB == null) throw new System.Exception("Erro: não foi possível atualizar, pois o usuario não existe no banco de dados");

            usuarioDB.Matricula = usuario.Matricula;
            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Autorizacao = usuario.Autorizacao;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Telefone = usuario.Telefone;
            usuarioDB.DataAtualizacao = System.DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public UsuarioModel BuscarPorLogin(string login)
		{
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Matricula.ToUpper() == login.ToUpper());
        }

		public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
    }
}
