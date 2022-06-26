using Microsoft.Net.Http.Headers;
using service_desk.Data;
using service_desk.Helper;
using System.Net.Http;

namespace service_desk.Repositorio
{
    public class GLPI : Repositorio
    {
        public GLPI(BancoContext bancoContext, ISessao sessao, IHttpClientFactory httpClientFactory) : base(bancoContext, sessao)
        {
            _httpClientFactory = httpClientFactory;
        }

        private readonly IHttpClientFactory _httpClientFactory;

        public async void RecuperarSessionToken()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://hservicedesk.tcees.tc.br/apirest.php/initSession") { Headers = { { HeaderNames.Authorization, "user_token xfizfRBtFtSSNavTkukquZNJRaNH3d1gSCRMBWaV" } } };
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            var response = await httpClient.SendAsync(request);

            var token = await response.Content.ReadAsStringAsync();
        }

        public async void ObterDadosUsuarioPelaMatricula()
        {
            string matricula = "t203892"; // ######################################################################## MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/search/User?criteria[0][link]=AND&criteria[0][field]=1&criteria[0][searchtype]=contains&forcedisplay[0]=2&criteria[0][value]={matricula}");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ################################## MUDAR
            var response = await httpClient.SendAsync(request);

            var dadosUsuario = await response.Content.ReadAsStringAsync();
        }

        public async void CriarChamado()
        {
            // POST
            // https://hservicedesk.tcees.tc.br/apirest.php/Ticket
            // Headers: Session-Token, App-Token
            // Body: "input": [ "name": "Chamado",  "content": "Descrição do teste", "status": 1, "urgency": 3, "priority": 2, "_users_id_requester": "227", "users_id_recipient": "227" ]
            // Resposta: "id": 28784, "message": "Item adicionado com sucesso: Chamado"
        }

        public async void ObterDadosIdChamado()
        {
            string idChamado = "7974"; // ############################################################################## MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/search/Ticket?criteria[0][field]=2&criteria[0][searchtype]=equals&criteria[0][value]={idChamado}");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ##################################### MUDAR
            var response = await httpClient.SendAsync(request);

            var dadosChamado = await response.Content.ReadAsStringAsync();
        }

        public async void ObterChamadosPorUsuario()
        {
            string idUsuario = "227"; // ############################################################################### MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/search/Ticket?criteria[0][field]=4&criteria[0][searchtype]=equals&criteria[0][value]={idUsuario}&order=ASC");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ##################################### MUDAR
            var response = await httpClient.SendAsync(request);

            var chamadosUsuario = await response.Content.ReadAsStringAsync();
        }

        public async void ObterAcompanhamentosDoChamado()
        {
            string idChamado = "28784"; // ############################################################################################################# MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/Ticket/{idChamado}/TicketFollowUp");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ##################################################################### MUDAR
            var response = await httpClient.SendAsync(request);

            var acompanhamentosChamado = await response.Content.ReadAsStringAsync();
        }

        public async void ObterSolucaoDoChamado()
        {
            string idChamado = "28784"; // ############################################################################################################# MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/Ticket/{idChamado}/ITILSolution");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ##################################################################### MUDAR
            var response = await httpClient.SendAsync(request);

            var solucaoChamado = await response.Content.ReadAsStringAsync();
        }

        public async void ObterSatisfacaoDoChamado()
        {
            string idChamado = "28784"; // ############################################################################################################# MUDAR
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://hservicedesk.tcees.tc.br/apirest.php/Ticket/{idChamado}/TicketSatisfaction");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", "tn5mhgf2l9bnfa2ci6muo3f9qq"); // ##################################################################### MUDAR
            var response = await httpClient.SendAsync(request);

            var satisfacaoChamado = await response.Content.ReadAsStringAsync();
        }

        public async void InserirAcompanhamento()
        {
            // POST
            // https://hservicedesk.tcees.tc.br/apirest.php/Ticket/28784/ITILFollowup
            // Headers: Session-Token, App-Token
            // Body: "input": { "itemtype": "Ticket", "items_id": "18025", "is_private": "0", "requesttypes_id": "1", "content": "Followup contents" }
            // Resposta: "id": 39177, "message": ""
        }
    }
}
