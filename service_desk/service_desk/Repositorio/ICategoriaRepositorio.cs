using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface ICategoriaRepositorio
    {
        CategoriaModel ListarPorId(int id);

        List<CategoriaModel> BuscarTodos();

        CategoriaModel Adicionar(CategoriaModel categoria);

        CategoriaModel Atualizar(CategoriaModel categoria);

        bool Apagar(int id);
    }
}
