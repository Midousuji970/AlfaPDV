using AlfaPdv.Classes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AlfaPdv.Services
{
    internal class ProdServices
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<VerProd> BuscarProduto(int id)
        {
            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/produto.php?id={id}");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            // A resposta é um array JSON, precisamos desserializar para uma lista
            List<VerProd> produtos = JsonConvert.DeserializeObject<List<VerProd>>(jsonString);

            // Retornamos o primeiro item da lista, assumindo que o filtro de ID na API funciona corretamente
            return produtos?.FirstOrDefault();
        }
        public async Task<VerProd> BuscarProduto2(int id)
        {
            conexao conf = new conexao();
            string conecta = conf.ConexaoBD;

            using (MySqlConnection con = new MySqlConnection(conecta))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ")) { }
            }
                return null;
        }

        public async Task<List<VerProd>> Produ()
        {
            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/produto.php");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            List<VerProd> produtos = JsonConvert.DeserializeObject<List<VerProd>>(jsonString);
            return produtos;
        }
    }
}
