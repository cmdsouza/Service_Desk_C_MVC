using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface ILocalizacaoRepositorio
    {
        LocalizacaoModel ListarPorId(int id);

        List<LocalizacaoModel> BuscarTodos();

        LocalizacaoModel Adicionar(LocalizacaoModel localizacao);

        LocalizacaoModel Atualizar(LocalizacaoModel localizacao);

        bool Apagar(int id);
    }
}
