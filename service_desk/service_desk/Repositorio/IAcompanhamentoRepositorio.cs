using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IAcompanhamentoRepositorio
    {
        AcompanhamentoModel ListarPorId(int id);

        List<AcompanhamentoModel> BuscarTodos();

        AcompanhamentoModel Adicionar(AcompanhamentoModel acompanhamento);

        AcompanhamentoModel Atualizar(AcompanhamentoModel acompanhamento);

        bool Apagar(int id);
    }
}
