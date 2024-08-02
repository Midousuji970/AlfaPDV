using AlfaPdv.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlfaPdv.Services
{
    internal class FunServices
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public async Task<ChamarFun> Integracao(int id)
        {

            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/login.php?tabela=funcionario&id={id}");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            ChamarFun jason = JsonConvert.DeserializeObject<ChamarFun>(jsonString);

            return jason;

        }

        public async Task<List<VerFun>> Integra()
        {

            var ver = await httpClient.GetAsync($"http://localhost/Portfolio/teste.php?tabela=funcionario");
            var jsonFun = await ver.Content.ReadAsStringAsync();

            List<VerFun> fila = JsonConvert.DeserializeObject<List<VerFun>>(jsonFun);
            return fila;

        }

        public async Task<FunCompleto> FunFullIntegra(int id)
        {

            var vera = await httpClient.GetAsync($"http://localhost/Portfolio/login.php?tabela=funcionario&id={id}");
            var jsonFunFull = await vera.Content.ReadAsStringAsync();

            FunCompleto full = JsonConvert.DeserializeObject<FunCompleto>(jsonFunFull);
            return full;

        }

        public async Task<HttpResponseMessage> Puts(HttpRequestMessage request)
        {
            try
            {
                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro na atualização: {response.StatusCode}, Detalhes: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fazer a solicitação PUT: " + ex.Message, ex);
            }
        }
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            try
            {
                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro na criação: {response.StatusCode}, Detalhes: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fazer a solicitação POST: " + ex.Message, ex);
            }
        }
        public async Task Remover(int id, string nome)
        {
            var jsonBody = $"{{\n\t\"id\": \"{id}\",\n\t\"nome\": \"{nome}\"\n}}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://localhost/Portfolio/funcionario.php"),
                Headers =
            {
                { "User-Agent", "insomnia/8.6.1" },
            },
                Content = new StringContent(jsonBody)
                {
                    Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
                }
            };

            try
            {
                using (var response = await httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                     // Você pode remover essa linha se não precisar do corpo da resposta
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Erro ao fazer a solicitação DELETE: " + ex.Message, ex);
            }
        }


    }   
        
}
