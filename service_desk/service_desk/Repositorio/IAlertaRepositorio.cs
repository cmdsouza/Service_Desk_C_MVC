using service_desk.Models;
using System.Collections.Generic;

namespace service_desk.Repositorio
{
    public interface IAlertaRepositorio
    {
        AlertaModel ListarPorId(int id);

        List<AlertaModel> BuscarTodos();

        List<AlertaModel> ListarAtivo();

        AlertaModel Adicionar(AlertaModel alerta);

        AlertaModel Atualizar(AlertaModel alerta);

        AlertaModel AtivarStatus(AlertaModel alerta);

        AlertaModel DesativarStatus(AlertaModel alerta);
        
        bool Apagar(int id);
    }
}
