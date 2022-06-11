using Microsoft.AspNetCore.Mvc;
using service_desk.Data;
using service_desk.Helper;
using service_desk.Models;

namespace service_desk.Repositorio
{
    public class Repositorio
    {
        protected readonly UsuarioModel _usuario;
        protected readonly BancoContext _bancoContext;

        public Repositorio(BancoContext bancoContext, ISessao sessao)
        {
            _usuario = sessao.BuscarSessaoDoUsuario();
            _bancoContext = bancoContext;
        }
    }
}
