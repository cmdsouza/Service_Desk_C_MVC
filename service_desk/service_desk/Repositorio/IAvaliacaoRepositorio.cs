using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IAvaliacaoRepositorio
    {
        AvaliacaoModel ListarPorId(int id);

        List<AvaliacaoModel> BuscarTodos();

        AvaliacaoModel Adicionar(AvaliacaoModel avaliacao);

        AvaliacaoModel Atualizar(AvaliacaoModel avaliacao);

        bool Apagar(int id);
    }
}
