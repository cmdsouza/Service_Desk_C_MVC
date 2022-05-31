using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IAnexoRepositorio
    {
        AnexoModel ListarPorId(int id);

        List<AnexoModel> BuscarTodos();

        AnexoModel Adicionar(AnexoModel anexo);

        AnexoModel Atualizar(AnexoModel anexo);

        bool Apagar(int id);
    }
}
