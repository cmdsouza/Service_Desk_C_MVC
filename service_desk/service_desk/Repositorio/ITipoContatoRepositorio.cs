using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface ITipoContatoRepositorio
    {
        TipoContatoModel ListarPorId(int id);

        List<TipoContatoModel> BuscarTodos();

        TipoContatoModel Adicionar(TipoContatoModel tipoContato);

        TipoContatoModel Atualizar(TipoContatoModel tipoContato);

        bool Apagar(int id);
    }
}
