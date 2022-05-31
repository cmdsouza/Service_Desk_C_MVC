using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IDocumentacaoRepositorio
    {
        DocumentacaoModel ListarPorId(int id);

        List<DocumentacaoModel> BuscarTodos();

        DocumentacaoModel Adicionar(DocumentacaoModel documentacao);

        DocumentacaoModel Atualizar(DocumentacaoModel documentacao);

        bool Apagar(int id);
    }
}
