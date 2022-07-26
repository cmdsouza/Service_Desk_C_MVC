using Microsoft.Net.Http.Headers;
using service_desk.Data;
using service_desk.Helper;
using System.Net.Http;
using Newtonsoft.Json;
using service_desk.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System;
using Microsoft.Extensions.Configuration;
using static service_desk.Models.DadosUsuarioModel;
using static service_desk.Models.ChamadosUsuarioModel;
using static service_desk.Models.ChamadosSolucionadosUsuarioModel;

namespace service_desk.Repositorio
{
    public class GLPI : Repositorio
    {
        public GLPI(BancoContext bancoContext, ISessao sessao, IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(bancoContext, sessao)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public async Task<SessionTokenModel> RecuperarSessionToken()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, _configuration["URLGLPI"] + "/initSession") { Headers = { { HeaderNames.Authorization, "user_token xfizfRBtFtSSNavTkukquZNJRaNH3d1gSCRMBWaV" } } };
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            var response = await httpClient.SendAsync(request);

            var token = await response.Content.ReadAsStringAsync();
            var sessionToken = JsonConvert.DeserializeObject<SessionTokenModel>(token);

            var resultado = new TaskCompletionSource<SessionTokenModel>();
            resultado.SetResult(sessionToken);

            return await resultado.Task;
        }

        public async Task<DadosUsuario> ObterDadosUsuarioPelaMatricula(string matricula)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/search/User?criteria[0][link]=AND&criteria[0][field]=1&criteria[0][searchtype]=contains&forcedisplay[0]=2&criteria[0][value]={matricula}");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosUsuario = await response.Content.ReadAsStringAsync();
            var usuario = JsonConvert.DeserializeObject<DadosUsuario>(dadosUsuario);

            var resultado = new TaskCompletionSource<DadosUsuario>();
            resultado.SetResult(usuario);

            return await resultado.Task;
        }

        public async void CriarChamado()
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, _configuration["URLGLPI"] + "/Ticket");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);

            request.Content = JsonContent.Create(new { input = new [] { new { name = "Chamado de teste " + DateTime.Now.ToLongDateString(), content = "Descrição do teste", status = 1, urgency = 3, priority = 2, _users_id_requester = "227", users_id_recipient = "227" } } });

            var response = await httpClient.SendAsync(request);
            var dadosChamado = await response.Content.ReadAsStringAsync();
        }

        public async Task<DadosChamadoModel> ObterDadosIdChamado(int idChamado)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/ticket/{idChamado}");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosChamado = await response.Content.ReadAsStringAsync();
            var chamado = JsonConvert.DeserializeObject<DadosChamadoModel>(dadosChamado);

            var resultado = new TaskCompletionSource<DadosChamadoModel>();
            resultado.SetResult(chamado);

            return await resultado.Task;
        }

        public async Task<ChamadosUsuario> ObterChamadosPorUsuario(int idUsuario)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/search/Ticket?criteria[0][field]=4&criteria[0][searchtype]=equals&criteria[0][value]={idUsuario}&order=ASC");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var usuarioChamados = await response.Content.ReadAsStringAsync();
            var chamados = JsonConvert.DeserializeObject<ChamadosUsuario>(usuarioChamados);

            var resultado = new TaskCompletionSource<ChamadosUsuario>();
            resultado.SetResult(chamados);

            return await resultado.Task;
        }

        public async Task<DadosAcompanhamentoModel> ObterAcompanhamentosDoChamado(int idChamado)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/Ticket/{idChamado}/TicketFollowUp");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosAcompanhamento = await response.Content.ReadAsStringAsync();
            var acompanhamentos = JsonConvert.DeserializeObject<DadosAcompanhamentoModel>(dadosAcompanhamento);

            var resultado = new TaskCompletionSource<DadosAcompanhamentoModel>();
            resultado.SetResult(acompanhamentos);

            return await resultado.Task;
        }

        public async Task<DadosSolucaoModel> ObterSolucaoDoChamado(int idChamado)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/Ticket/{idChamado}/ITILSolution");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosSolucao = await response.Content.ReadAsStringAsync();
            var solucao = JsonConvert.DeserializeObject<DadosSolucaoModel>(dadosSolucao);

            var resultado = new TaskCompletionSource<DadosSolucaoModel>();
            resultado.SetResult(solucao);

            return await resultado.Task;
        }

        public async Task<DadosSatisfacaoModel> ObterSatisfacaoDoChamado(int idChamado)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/Ticket/{idChamado}/TicketSatisfaction");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosSatisfacao = await response.Content.ReadAsStringAsync();
            var satisfacao = JsonConvert.DeserializeObject<DadosSatisfacaoModel>(dadosSatisfacao);

            var resultado = new TaskCompletionSource<DadosSatisfacaoModel>();
            resultado.SetResult(satisfacao);

            return await resultado.Task;
        }

        public async void InserirAcompanhamento(int idChamado)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, $"{_configuration["URLGLPI"]}/Ticket/{idChamado}/ITILFollowup");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);

            request.Content = JsonContent.Create(new { input = new[] { new { itemtype = "Ticket", items_id = "18025", is_private = "0", requesttypes_id = "1", content = "Followup contents" + DateTime.Now.ToLongDateString() } } });

            var response = await httpClient.SendAsync(request);
            var dadosAcompanhamento = await response.Content.ReadAsStringAsync();
        }

        public async Task<ChamadosSolucionadosUsuario> QuantidadeChamadosSolucionados(int idUsuario)
        {
            var sessionToken = RecuperarSessionToken().Result;

            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["URLGLPI"]}/search/Ticket?is_deleted=0&as_map=0&criteria[0][link]=AND&criteria[0][field]=4&criteria[0][searchtype]=equals&criteria[0][value]={idUsuario}&criteria[1][link]=AND&criteria[1][criteria][0][link]=AND&criteria[1][criteria][0][field]=12&criteria[1][criteria][0][searchtype]=equals&criteria[1][criteria][0][value]=5&criteria[1][criteria][1][link]=OR&criteria[1][criteria][1][field]=12&criteria[1][criteria][1][searchtype]=equals&criteria[1][criteria][1][value]=6&criteria[1][criteria][2][link]=OR&criteria[1][criteria][2][field]=12&criteria[1][criteria][2][searchtype]=equals&criteria[1][criteria][2][value]=old");
            request.Headers.Add("App-Token", "43GWHcxGtagItPsUJy5bGCzVsMIJgq1rWhsd99Y3");
            request.Headers.Add("Session-Token", sessionToken.session_token);
            var response = await httpClient.SendAsync(request);

            var dadosChamados = await response.Content.ReadAsStringAsync();
            var chamados = JsonConvert.DeserializeObject<ChamadosSolucionadosUsuario>(dadosChamados);

            var resultado = new TaskCompletionSource<ChamadosSolucionadosUsuario>();
            resultado.SetResult(chamados);

            return await resultado.Task;
        }
    }
}
