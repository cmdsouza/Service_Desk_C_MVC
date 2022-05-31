using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IChamadoRepositorio
    {
        ChamadoModel ListarPorId(int id);

        List<ChamadoModel> BuscarTodos();

        ChamadoModel Adicionar(ChamadoModel chamado);

        ChamadoModel Atualizar(ChamadoModel chamado);

        bool Apagar(int id);
    }
}
