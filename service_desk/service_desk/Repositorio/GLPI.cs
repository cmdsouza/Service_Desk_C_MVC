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
    }
}
